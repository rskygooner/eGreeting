using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eGreeting.Models;
using eGreeting.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eGreeting.Controllers
{
    public class UserController : BaseController
    {
        private readonly ICardServices _cardServices;
        private readonly IUserServices _userServices;
        private readonly IPaymentServices _paymentServices;
        private readonly IFeedbackServices _feedbackServices;
        private readonly ISubscribleServices _emailListServices;
        private readonly ITransactionServices _transactionServices;
        public UserController(ICardServices cardServices,
            IUserServices userServices,
            IPaymentServices paymentServices,
            IFeedbackServices feedbackServices,
            ISubscribleServices emailListServices,
            ITransactionServices transactionServices)
        {
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
                var user = _userServices.GetUser(HttpContext.Session.GetString("username"));
                return View(user);
            }
            Alert("You need login to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        // GET: User/Create
        public IActionResult Register()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return View();
            }
            else
            {
                Alert("You must logout first to register new account!", NotificationType.warning);
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserViewModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var search = _userServices.CheckExistUser(user.UserName, user.Email);
                    if (search == null)
                    {
                        if (_userServices.CreateUser(user))
                        {
                            Alert("Register Successfully! Please login", NotificationType.success);
                            HttpContext.Session.SetString("username", user.UserName);
                            HttpContext.Session.SetString("fullname", user.FullName);
                            HttpContext.Session.SetString("role", Role.User.ToString().ToLower());
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Username or email is existed");
                        return View();
                    }
                }
                ModelState.AddModelError("", "Create new User failed!");
                return View();
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }

        // GET: User/Edit/5
        public IActionResult Edit(string username)
        {
            if (IsLoggedIn())
            {
                var user = _userServices.GetUser(HttpContext.Session.GetString("username"));
                if (user.Role == Role.User)
                {
                    var edit = _userServices.GetUser(username);
                    return View(edit);
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(User user)
        {
            var search = _userServices.GetUser(user.UserName);
            if (ModelState.IsValid)
            {
                _userServices.EditUser(user);
                Alert("Edited successfully!!", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                if (search != null)
                {
                    return View(search);
                }
                Alert("Cannot get User", NotificationType.error);
                return RedirectToAction("Index");
            }
        }

        //Phuc
        public IActionResult EditPaymentInfo()
        {
            if (IsLoggedIn())
            {
                var findPaymentInfo = _paymentServices.GetPaymentByUsername(HttpContext.Session.GetString("username"));
                if (findPaymentInfo == null)
                {
                    Alert("Your Payment Info are not registered!!", NotificationType.warning);
                    return RedirectToAction("Index");
                }
                return View(findPaymentInfo);
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPaymentInfo(PaymentInfo payment)
        {
            if (ModelState.IsValid)
            {

                if (_paymentServices.EditPayment(payment))
                {
                    Alert("Edited successfully!!", NotificationType.success);
                    var search = _paymentServices.GetPayment(payment.PayId);
                    if (search != null)
                    {
                        return View(search);
                    }
                    return RedirectToAction("Index");
                }
                else
                {
                    Alert("Edited failed!!", NotificationType.error);
                    return View();
                }
            }
            else
            {
                Alert("Edited failed!!", NotificationType.error);
                return View();
            }
        }
        // End Phuc

        public IActionResult ChangePassword(int id)
        {
            if (IsLoggedIn())
            {
                if (id > 0)
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public IActionResult ChangePassword(User user)
        {
            if (ModelState.IsValid)
            {
                var existUser = _userServices.GetUser(HttpContext.Session.GetString("username"));
                if (existUser != null)
                {
                    _userServices.ChangePassword(user);

                    Alert("Change Password successfully!!", NotificationType.success);
                    return RedirectToAction("Index");
                }
                Alert("Not found this user.", NotificationType.error);
                return View();
            }
            else
            {
                return View();
            }
        }


        // GET: User/CreateFeedback
        public IActionResult Feedback()
        {
            if (IsLoggedIn())
            {
                return View();
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Feedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.DateCreated = DateTime.Now;
                if (_feedbackServices.CreateFeedback(feedback))
                {
                    Alert("Send feedback successfully!", NotificationType.success);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Alert("Send feedback failed!", NotificationType.error);
                    return View();
                }
            }
            return View();
        }

        //GET: User/CreateTrans
        public IActionResult CreateTransaction(int id)
        {
            if (IsLoggedIn())
            {
                var username = HttpContext.Session.GetString("username");
                var searchCard = _cardServices.GetCard(id);
                if (searchCard != null)
                {
                    var model = new Transaction
                    {
                        CardId = searchCard.CardId,
                        Username = username,
                        TransImage = searchCard.ImageName,
                    };
                    return View(model);
                }
                return RedirectToAction("Index");
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/CreateTrans
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateTransaction(Transaction transaction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    transaction.TimeSend = DateTime.UtcNow;
                    if (_transactionServices.CreateTransaction(transaction))
                    {
                        Alert("Send eGreeting card successfully.", NotificationType.success);
                        return RedirectToAction("Index", "Home");
                    }
                    Alert("Send card failed. Please contact Administrator!", NotificationType.error);
                    return RedirectToAction("Index", "Home");
                }
                return View(transaction);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
                throw;
            }
        }

        //GET: User/Payment
        public IActionResult Payment()
        {
            if (IsLoggedIn())
            {
                var searchUser = _userServices.GetUser(HttpContext.Session.GetString("username"));
                var model = new PaymentInfo
                {
                    UserName = searchUser.UserName,
                };
                return View(model);
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/Payment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Payment(PaymentInfo payment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //addPayment.DateCreated = DateTime.Now;
                    if (payment.DateExpire > DateTime.Now)
                    {
                        if (_paymentServices.CreatePayment(payment))
                        {
                            Alert("Register payment account successfully. Please wait until we activate your payment. Thank you! ", NotificationType.success);
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    Alert("Expire Date must be date in future", NotificationType.error);
                }
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
                throw;
            }
        }

        //==================================================== Subscribes ===========================================================================

        //GET: //User/SubscribeSend
        public IActionResult SubscribeSend()
        {
            if (IsLoggedIn())
            {
                var username = HttpContext.Session.GetString("username");
                var searchPayment = _paymentServices.GetPaymentByUsername(username);
                if (searchPayment == null)
                {
                    Alert("You must register Payment Info to use this feature.", NotificationType.error);
                    return RedirectToAction("Payment", "User");
                }
                var search = _userServices.GetUser(username);
                //if (search.IsSubcribeSend)
                //{
                //    return RedirectToAction("ChangeSubscribeSend");
                //}
                if (searchPayment.IsActive == Status.Inactive)
                {
                    Alert("You Payment Not Activate. Please Contact Administrator. Thank you.", NotificationType.error);
                    return RedirectToAction("FeedbackIndex", "User");
                }
                return View();
            }
            Alert("You need Log in to access this page!", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //GET: User/ChangeSubscribeSend/5
        public IActionResult ChangeSubscribeSend()
        {
            if (IsLoggedIn())
            {
                var search = _userServices.GetUser(HttpContext.Session.GetString("username"));
                if (search != null)
                {
                    return View(search);
                }
                return RedirectToAction("Index", "Home");
            }
            Alert("You need Log in to access this page!", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }


        //GET: User/EditSubscribe/5
        public IActionResult EditSubscribe(string username)
        {
            if (IsLoggedIn())
            {
                var search = _userServices.GetUser(username);
                if (search != null)
                {
                    return View(search);
                }
                Alert("Not found User", NotificationType.error);
                return RedirectToAction("Index");
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/AddEmailList
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSubscribleList(SubscribeList subscribe)
        {
            if (subscribe.SubscribeEmail != null)
            {
            }
            Alert("Please do not empty fields", NotificationType.error);
            return RedirectToAction("SubscribeSend");
        }

        //GET: User/EditEmailList/5
        public IActionResult EditSubscribleList(string username)
        {
            if (IsLoggedIn())
            {
                if (username != null)
                {
                    //var search = _emailListServices.GetEmailListByUsername(username);
                    //if (search != null)
                    //{
                    //    return View(search);
                    //}
                    Alert("Not found Email List with this Username", NotificationType.error);
                    return RedirectToAction("Index");
                }
                Alert("Username was null", NotificationType.error);
                return View();
            }
            Alert("You need Log in to access this page!", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //GET: User/SubscribeReceive
        public IActionResult SubscribeReceive()
        {
            if (IsLoggedIn())
            {
                var searchUser = _userServices.GetUser(HttpContext.Session.GetString("username").ToLower());
                if (searchUser != null)
                {
                    return View(searchUser);
                }
                Alert("Not found this Username", NotificationType.error);
                return RedirectToAction("Index", "Home");
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/SubscribeReceive
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubscribeReceive(User editUser)
        {
            var search = _paymentServices.GetPaymentByUsername(HttpContext.Session.GetString("username").ToLower());
            if (search != null)
            {
                if (search.IsActive == Status.Active)
                {
                    var searchUser = _userServices.GetUser(search.UserName);
                    if (searchUser != null)
                    {
                        //if (_userServices.UpdateSubscribeReceive(searchUser))
                        //{
                        //    Alert("Subscribe Daily Receive New Card Successfully", NotificationType.success);
                        //    return RedirectToAction("Index", "Home");
                        //}
                    }
                    Alert("Not found Username", NotificationType.error);
                    return RedirectToAction("SubscribeReceive");
                }
                Alert("Your Payment is not activated. Please contact Administrator by send feedback.", NotificationType.error);
                return RedirectToAction("FeedbackIndex");
            }
            Alert("Sorry You not register Payment Information. Please register first!", NotificationType.error);
            return RedirectToAction("Payment");
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