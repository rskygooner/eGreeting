using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using eGreeting.Models;
using eGreeting.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace eGreeting.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ICategoryServices _categoryServices;
        private readonly ICardServices _cardServices;
        private readonly IUserServices _userServices;
        private readonly IPaymentServices _paymentServices;
        private readonly IFeedbackServices _feedbackServices;
        private readonly ISubscribleServices _emailListServices;
        private readonly ITransactionServices _transactionServices;
        public AdminController(IWebHostEnvironment environment,
            ICardServices cardServices,
            ICategoryServices categoryServices,
            IUserServices userServices,
            IPaymentServices paymentServices,
            IFeedbackServices feedbackServices,
            ISubscribleServices emailListServices,
            ITransactionServices transactionServices)
        {
            _hostingEnvironment = environment;
            _categoryServices = categoryServices;
            _cardServices = cardServices;
            _userServices = userServices;
            _paymentServices = paymentServices;
            _feedbackServices = feedbackServices;
            _emailListServices = emailListServices;
            _transactionServices = transactionServices;
        }

        public IActionResult Index()
        {
            if (IsLoggedIn())
            {
                if (IsAdmin())
                {
                    return View();
                }
                Alert("You not permit to access that page", NotificationType.warning);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login");
        }

        //GET: Admin/Login
        public IActionResult Login()
        {
            var username = HttpContext.Session.GetString("username");
            if (username != null)
            {
                return RedirectToAction("Index");
            }
            Alert("Attention: If you are not Administrator. Please leave from there. Thank you", NotificationType.warning);
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User user)
        {
            var search = _userServices.CheckLogin(user);
            if (search != null)
            {
                if (search.Role == Role.User)
                {
                    Alert("You are not Administrator. Please do not try login here. Thank you.", NotificationType.warning);
                    return RedirectToAction("Index", "Home");
                }
                HttpContext.Session.SetString("username", search.UserName);
                HttpContext.Session.SetString("fullname", search.FullName);
                HttpContext.Session.SetString("role", search.Role.ToString());
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                Alert("Invalid Account", NotificationType.error);
            }
            return View();
        }

        //Manage Feedback//
        // GET: Admin/ManageFeedback
        public IActionResult ManageFeedback(int? page)
        {
            if (IsAdmin())
            {
                int maxSize = 5;
                var pageNum = page ?? 1;
                var feedbacks = _feedbackServices.GetAllFeedback().OrderByDescending(x => x.DateCreated).ToPagedList(pageNum, maxSize);
                ViewBag.page = feedbacks;
                return View();
            }
            Alert("You not permit to access that page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        public IActionResult DetailFeedback(int id)
        {
            Feedback feedback = _feedbackServices.GetFeedback(id);
            return View(feedback);
        }

        [HttpPost]
        public IActionResult DeleteFeedback(int id)
        {
            try
            {
                if (IsAdmin())
                {
                    if (id > 0)
                    {
                        if (_feedbackServices.DeleteFeedback(id))
                        {
                            Alert("Delete feedback successfully", NotificationType.success);
                            return RedirectToAction("ManageFeedback");
                        }
                    }
                }
                Alert("You not permit to access that page", NotificationType.warning);
                return RedirectToAction("ManageFeedback");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction("ManageFeedback");
            }
        }

        //Manage Card//
        // GET: Admin/ManageCard
        public IActionResult ManageCard(string pName, int? page)
        {
            if (IsAdmin())
            {
                var cards = _cardServices.GetCards();
                int maxSize = 9;
                var pageNum = page ?? 1;
                if (!string.IsNullOrEmpty(pName))
                {
                    var model = cards.Where(x => x.CardName.Contains(pName.ToLower()) || x.CardName.Contains(pName.ToUpper()))
                        .OrderBy(x=>x.CardName)
                        .ToPagedList(pageNum, maxSize);
                    ViewBag.page = model;
                    return View();
                }
                else
                {
                    var model = cards.OrderBy(x => x.CardName).ToPagedList(pageNum, maxSize);
                    ViewBag.page = model;
                    return View();
                }
            }
            Alert("You not permit to access that page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        // GET: Admin/CreateCard
        public IActionResult CreateCard()
        {
            if (IsAdmin())
            {
                var categoryList = _categoryServices.GetCategories();
                ViewBag.data = new SelectList(categoryList, "CategoryId", "CategoryName");
                return View();
            }
            Alert("You not permit to access that page", NotificationType.warning);
            return RedirectToAction("Index", "Home");
        }

        // POST: Admin/CreateCard
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateCard(Card newCard,IFormFile file)
        {
            try
            {
                if (IsAdmin())
                {
                    if (ModelState.IsValid)
                    {
                        if (file != null && file.Length > 0)
                        {
                            if (_cardServices.GetNameCard(newCard.CardName))
                            {
                                Alert("Namecard has been exist.", NotificationType.error);
                                return View();
                            }

                            var ext = Path.GetExtension(file.FileName);
                            if (CheckExtImg(ext))
                            {
                                var fileName = Path.GetFileName(file.FileName);
                                var uploads = Path.Combine(_hostingEnvironment.WebRootPath,"ImageCard");
                                newCard.ImageName = fileName;
                                newCard.DateCreated = DateTime.Now;
                                if (_cardServices.GetImageCard(fileName))
                                {
                                    Alert("Image Name has been exist.", NotificationType.error);
                                    return View();
                                }
                                if (_cardServices.CreateCard(newCard))
                                {
                                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                                    {
                                        file.CopyTo(fileStream);
                                    }
                                    //file.SaveAs(imagePath);
                                    Alert("Create new Card successfully", NotificationType.success);
                                    return RedirectToAction("ManageCard");
                                }
                                Alert("Create new card failed.", NotificationType.error);
                                return View();
                            }
                            else
                            {
                                Alert("File format invalid. Please select file *.png/.jpg/.jpeg.", NotificationType.error);
                                return View();
                            }
                        }
                        else
                        {
                            Alert("Please choose Image", NotificationType.error);
                            return View();
                        }
                    }
                    return View();
                }
                Alert("You not permit to access that page", NotificationType.warning);
                return RedirectToAction("Login", "Home");
            }
            catch (Exception e)
            {
                Alert(e.Message, NotificationType.error);
                return View();
            }
        }

        //GET: Admin/EditCard/5
        public IActionResult EditCard(int id)
        {
            try
            {
                if (IsAdmin())
                {
                    var search = _cardServices.GetCard(id);
                    if (search != null)
                    {
                        var categoryList = _categoryServices.GetCategories();
                        ViewBag.data = new SelectList(categoryList, "CategoryId", "CategoryName");
                        return View(search);
                    }
                    Alert("Cannot get Card", NotificationType.error);
                    return RedirectToAction("Index");
                }
                Alert("You not permit to access that page", NotificationType.warning);
                return RedirectToAction("Login", "Home");

            }
            catch (Exception e)
            {
                Alert(e.Message, NotificationType.error);
                return RedirectToAction("Index");
                throw;
            }
        }

        //POST: Admin/EditCard/5
        [HttpPost]
        public IActionResult EditCard(Card editCard, IFormFile file)
        {
            try
            {
                if (IsAdmin())
                {
                    if (ModelState.IsValid)
                    {
                        if (file != null && file.Length > 0)
                        {
                            var ext = Path.GetExtension(file.FileName);
                            if (CheckExtImg(ext))
                            {
                                var fileName = Path.GetFileName(file.FileName);
                                var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "ImageCard");
                                editCard.ImageName = fileName;
                                if (editCard.DateCreated == null)
                                {
                                    editCard.DateCreated = DateTime.Now;
                                }

                                if (_cardServices.EditCard(editCard))
                                {
                                    using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                                    {
                                        file.CopyTo(fileStream);
                                    }
                                    //file.SaveAs(imagePath);
                                    Alert("Update Card successfully", NotificationType.success);
                                    return RedirectToAction("ManageCard");
                                }
                                Alert("Update card failed.", NotificationType.error);
                                return View();
                            }
                            else
                            {
                                Alert("File format invalid. Please select file *.png/.jpg/.jpeg.", NotificationType.error);
                                return View();
                            }
                        }
                        else
                        {
                            if (editCard.DateCreated == null)
                            {
                                editCard.DateCreated = DateTime.Now;
                            }
                            if (_cardServices.EditCard(editCard))
                            {
                                Alert("Update Card successfully", NotificationType.success);
                                return RedirectToAction("ManageCard");
                            }
                            Alert("Update card failed.", NotificationType.error);
                            return View();
                        }
                    }
                    return RedirectToAction("Index");
                }
                Alert("You not permit to access that page", NotificationType.warning);
                return RedirectToAction("Login", "Home");
            }
            catch (Exception e)
            {
                Alert(e.Message, NotificationType.error);
                return View();
            }
        }

        private readonly List<string> ImageExtension = new List<string> { ".png", ".jpg", ".jpeg" };

        bool CheckExtImg(string ext)
        {
            return ImageExtension.Contains(ext.ToLower());
        }


        // GET: Admin/Delete/5
        public IActionResult DeleteCard(int id)
        {
            try
            {
                if (IsAdmin())
                {
                    if (id >= 0)
                    {
                        if (_cardServices.DeleteCard(id))
                        {
                            return RedirectToAction("ManageCard");
                        }
                    }
                    Alert("Delete Card failed", NotificationType.error);
                    return RedirectToAction("ManageCard");
                }
                Alert("You not permit to access that page", NotificationType.warning);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return RedirectToAction("ManageCard");
            }
        }


        //Manage User//
        // GET: Admin/ManageUser
        public IActionResult ManageUser(int? page)
        {
            if (IsAdmin())
            {
                int maxSize = 5;
                var pageNum = page ?? 1;
                var users = _userServices.GetUsers().OrderBy(x=>x.Role).ToPagedList(pageNum, maxSize);
                ViewBag.page = users;
                return View();
            }
            Alert("You not permit to access that page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        // GET: Admin/CreateUser
        public IActionResult CreateUser()
        {
            if (IsAdmin())
            {
                return View();
            }
            Alert("You not permit to access this page", NotificationType.warning);
            return RedirectToAction("Index", "Home");
        }

        // POST: Admin/CreateUser
        [HttpPost]
        public IActionResult CreateUser(UserViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var search = _userServices.GetUser(user.UserName);
                    if (search == null)
                    {
                        if (_userServices.CreateUser(user))
                        {
                            Alert("Create User successfully!", NotificationType.success);
                            return RedirectToAction("ManageUser");
                        }
                    }
                    else
                    {
                        Alert("Username already exist!!", NotificationType.error);
                        return View();
                    }
                }
                ModelState.AddModelError("", "Create new User failed .");
                return View();
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }

        // GET: Admin/EditUser
        public IActionResult EditUser(string username)
        {
            try
            {
                var search = _userServices.GetUser(username);
                if (search != null)
                {
                    return View(search);
                }
                Alert("Not found user", NotificationType.error);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Alert(e.Message, NotificationType.error);
                return RedirectToAction("Index");
                throw;
            }
        }

        // POST: Admin/EditUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUser(User user)
        {
            try
            {
                var searchUser = _userServices.GetUser(user.UserName);
                if (searchUser == null)
                {
                    Alert("Not found This User", NotificationType.error);
                    return View();
                }
                if (user.UserName == "admin")
                {
                    user.Role = Role.Admin;
                }
                if (_userServices.EditUser(user))
                {
                    Alert("Edit User successfully!", NotificationType.success);
                    return RedirectToAction("ManageUser");
                }
                Alert("Edit User failed!", NotificationType.error);
                return View();
            }
            catch (Exception e)
            {
                Alert(e.Message, NotificationType.error);
                return View();
                throw;
            }
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public IActionResult DeleteUser(string username)
        {
            try
            {
                if (IsAdmin())
                {
                        if (_userServices.DeleteUser(username))
                        {
                            Alert("Delete User Successfully .", NotificationType.success);
                            return RedirectToAction("ManageUser");
                        }
                        else
                        {
                            Alert("Delete error, cannot find this User!!!", NotificationType.error);
                            return RedirectToAction("ManageUser");
                        }                    
                }
                Alert("You not permit to access that page", NotificationType.warning);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return RedirectToAction("ManageCard");
            }
        }

        //Manage Payment//
        // GET: /Admin/ManagePaymentInfo
        public IActionResult ManagePaymentInfo(int? page)
        {
            if (IsAdmin())
            {
                int maxSize = 5;
                var pageNum = page ?? 1;
                var payments = _paymentServices.GetPayments().OrderByDescending(x=>x.DateCreated).ToPagedList(pageNum, maxSize);
                ViewBag.page = payments;
                return View();
            }
            Alert("You not permit to access this page", NotificationType.error);
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public IActionResult EditPayment(int id, string IsActive)
        {
            if (_paymentServices.ChangeStatusActivation(id, Boolean.Parse(IsActive)))
            {
                var searchPayment = _paymentServices.GetPayment(id);
                if (searchPayment != null)
                {
                    var searchUser = _userServices.GetUser(searchPayment.UserName);
                    if (searchUser != null)
                    {
                           Alert("Change status activation successfully", NotificationType.success);
                            return RedirectToAction("ManagePaymentInfo");
                    }
                    Alert("Cannot found User.", NotificationType.error);
                    return View();
                }
                Alert("Cannot found Payment.", NotificationType.error);
                return View();
            }
            Alert("Change status activation failed.", NotificationType.error);
            return View();
        }

        //POST: /Admin/DeletePayment
        [HttpPost]
        public IActionResult DeletePayment(int id)
        {
            try
            {
                if (_paymentServices.DeletePayment(id))
                {
                    //Alert("Delete Payment Successfully .", NotificationType.success);
                    return RedirectToAction("ManagePaymentInfo");
                }
                else
                {
                    Alert("Delete error, cannot find this User!!!", NotificationType.error);
                    return RedirectToAction("ManagePaymentInfo");
                }
            }
            catch (Exception e)
            {
                Alert(e.Message, NotificationType.error);
                return RedirectToAction("ManagePaymentInfo");
                throw;
            }
        }

        //Manage Transaction//
        // GET: /Admin/ManageTrans

        public IActionResult ManageTransaction(int? page)
        {
            if (IsAdmin())
            {
                int maxSize = 9;
                var pageNum = page ?? 1;
                var transactions = _transactionServices.GetTransactions().OrderByDescending(x=>x.TimeSend).ToPagedList(pageNum, maxSize);
                ViewBag.page = transactions;
                return View();
            }
            Alert("You not permit to access this page", NotificationType.error);
            return RedirectToAction("Login", "Home");
        }
        public IActionResult DetailTransaction(int id)
        {
            var transaction = _transactionServices.GetTransaction(id);
            return View(transaction);
        }

        public IActionResult DeleteManageTransaction(int id)
        {
            try
            {
                if (_transactionServices.DeleteTransaction(id))
                {
                    Alert("Delete Transaction Successfully .", NotificationType.success);
                    return RedirectToAction("ManageTransactions");
                }
                else
                {
                    Alert("Delete Transaction error, cannot find this User!!!", NotificationType.error);
                    return RedirectToAction("ManageTransactions");
                }
            }
            catch (Exception e)
            {
                Alert(e.Message, NotificationType.error);
                return RedirectToAction("ManageTransactions");
                throw;
            }
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
            info,
            question
        }
    }
}