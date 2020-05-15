using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eGreeting.Models;
using eGreeting.Services;
using X.PagedList;
using Org.BouncyCastle.Bcpg.Sig;
using Microsoft.AspNetCore.Http;

namespace eGreeting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICardServices _cardServices;
        private readonly IUserServices _userServices;
        private readonly IPaymentServices _paymentServices;

        public HomeController(
            ICardServices cardServices,
            IUserServices userServices,
            IPaymentServices paymentServices)
        {
            _cardServices = cardServices;
            _userServices = userServices;
            _paymentServices = paymentServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Search(string txtSearch)
        {
            if (string.IsNullOrEmpty(txtSearch))
            {
                Alert("Please input name card to searching.", NotificationType.warning);
                return View("Index");

            }
            var search = _cardServices.SearchCards(txtSearch);
            if (search.Count == 0)
            {
                Alert("Not Found Any Card", NotificationType.error);
                return View("Index");
            }
            return View("Search", search);
        }

        //GET: Home/Birthday
        public IActionResult Birthday(int? page)
        {
            var Category = "Birthday";
            var search = _cardServices.GetCardsByCategory(Category);
            if (search.Count != 0)
            {

                if (page == null)
                {
                    page = 1;
                }
                int pageSize = 9;
                int pageNumber = (page ?? 1);
                return View(search.ToPagedList(pageNumber, pageSize));
            }
            else
            {
                return View("index");
            }
        }
        //GET: Home/NewYear
        public IActionResult NewYear(int? page)
        {
            var Category = "NewYear";
            var search = _cardServices.GetCardsByCategory(Category);

            if (search.Count != 0)
            {
                if (page == null)
                {
                    page = 1;
                }
                int pageSize = 9;
                int pageNumber = (page ?? 1);
                return View(search.ToPagedList(pageNumber, pageSize));
            }
            else
            {
                return View();
            }

        }
        //GET: Home/Festival
        public IActionResult Festival(int? page)
        {
            var Category = "Festival";
            var search = _cardServices.GetCardsByCategory(Category);

            if (search.Count != 0)
            {
                if (page == null)
                {
                    page = 1;
                }
                int pageSize = 9;
                int pageNumber = (page ?? 1);
                return View(search.ToPagedList(pageNumber, pageSize));
            }
            else
            {
                return View();
            }
        }

        //GET: Home/Login
        public IActionResult Login()
        {
            var username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // POST: Home/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User login)
        {
            var model = new User
            {
                UserName = login.UserName,
                Password = login.Password
            };
            var search = _userServices.CheckLogin(model);
            if (search != null)
            {
                if (search.IsActive != Status.Active)
                {
                    Alert("Your account has been block. Please contact Administrator.", NotificationType.warning);
                    return View();
                }
                HttpContext.Session.SetString("username", search.UserName);
                HttpContext.Session.SetString("fullname", search.FullName);
                HttpContext.Session.SetString("role", search.Role.ToString().ToLower());
                CheckActive(search);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Invalid Account", NotificationType.error);
            }
            return View();
        }

        // Phuc Check Payment Expire
        private void CheckActive(User user)
        {
            PaymentInfo item = _paymentServices.GetPaymentByUsername(user.UserName);
            if (item != null && item.DateCreated != null)
            {
                if (item.DateExpire < DateTime.Now)
                {
                    Alert("Your Payment Info was expired. Please Subscribe again. Thank you.", NotificationType.warning);
                    item.IsActive = Status.Active;
                    _paymentServices.EditPayment(item);
                }
            }
        }

        //GET: Home/Logout
        public IActionResult Logout()
        {
            var username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                HttpContext.Session.Clear();
                Alert("You has signed out!", NotificationType.success);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public void Alert(string message, NotificationType notificationType)
        {
            var msg = "<script language='javascript'>swal('" + notificationType.ToString().ToUpper() + "', '" + message + "','" + notificationType + "')" + "</script>";
            TempData["notification"] = msg;
        }

        public enum NotificationType
        {
            error,
            success,
            warning,
            info
        }
    }
}
