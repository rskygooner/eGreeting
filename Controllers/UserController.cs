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
        private readonly IEmailListServices _emailListServices;
        private readonly ITransactionServices _transactionServices;
        public UserController(ICardServices cardServices,
            IUserServices userServices,
            IPaymentServices paymentServices,
            IFeedbackServices feedbackServices,
            IEmailListServices emailListServices,
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
                var result = _userServices.GetUserByUsername(HttpContext.Session.GetString("username"));
                return View(result);
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
        public IActionResult Register(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (user.Password != user.RePassword)
                    {
                        Alert("RePassword does not match", NotificationType.error);
                        return View();
                    }
                    var search = _userServices.GetUserByUsername(user.UserName);
                    if (search == null)
                    {
                        if (_userServices.CreateUser(user))
                        {
                            Alert("Register Successfully!!", NotificationType.success);
                            HttpContext.Session.SetString("username", search.UserName);
                            HttpContext.Session.SetString("fullname", search.FullName);
                            HttpContext.Session.SetString("role", search.Role.ToString().ToLower());
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Username is existed");
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

        // GET: User/Edit/5
        public IActionResult Edit(int id)
        {
            if (IsLoggedIn())
            {
                if (id > 0)
                {
                    var edi = _userServices.GetUser(id);
                    return View(edi);
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
            var search = _userServices.GetUser(user.UserId);
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
                    var search = _userServices.GetUser(id);
                    var model = new ChangePassword
                    {
                        UserId = id,
                        OldPassword = search.Password,
                    };
                    return View(model);
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
        public IActionResult ChangePassword(ChangePassword changePassword)
        {
            if (ModelState.IsValid)
            {
                if (changePassword.NewPassword != changePassword.ConfirmNewPassword)
                {
                    Alert("Confirm New Password not match.", NotificationType.error);
                    return View();
                }
                var searchUser = _userServices.GetUser(changePassword.UserId);
                if (searchUser != null)
                {
                    if (searchUser.Password == changePassword.OldPassword)
                    {
                        var model = new User
                        {
                            UserId = changePassword.UserId,
                            Password = changePassword.NewPassword,
                        };
                        _userServices.ChangePassword(model);

                        Alert("Change Password successfully!!", NotificationType.success);
                        return RedirectToAction("Index");
                    }
                    Alert("Old Password invalid.", NotificationType.warning);
                    return View();
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
        public IActionResult FeedbackIndex()
        {
            if (IsLoggedIn())
            {
                var model = new Feedback
                {
                    Username = HttpContext.Session.GetString("username"),
                };
                return View(model);
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FeedbackIndex(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedback.DataCreated = DateTime.Now;
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
        public IActionResult CreateTrans(int id)
        {
            if (IsLoggedIn())
            {
                var username = HttpContext.Session.GetString("username");
                var searchUser = _userServices.GetUserByUsername(username);
                var searchPayment = _paymentServices.GetPaymentByUsername(username);
                if (searchPayment != null)
                {
                    if (searchUser == null)
                    {
                        Alert("You not Register Email List", NotificationType.error);
                        return RedirectToAction("SubscribeSend");
                    }
                    if (!searchPayment.IsActive)
                    {
                        Alert("Your Info Payment is not activated. Please contact Administrator by send feedback.", NotificationType.error);
                        return RedirectToAction("FeedbackIndex");
                    }
                    else
                    {
                        var searchCard = _cardServices.GetCard(id);
                        var searchEmailList = _emailListServices.GetEmailListByUsername(searchUser.UserName);
                        if (searchEmailList == null)
                        {
                            Alert("You not register email list to send Card. Please click Subscribe Send Card to register email list.", NotificationType.error);
                            return RedirectToAction("Index");
                        }
                        if (searchCard != null)
                        {
                            var model = new Transaction
                            {
                                NameCard = searchCard.NameCard,
                                Username = HttpContext.Session.GetString("username"),
                                ImageNameTrans = searchCard.ImageName,
                                Receiver = searchEmailList.ListEmail
                            };
                            return View(model);
                        }
                        return RedirectToAction("Index");
                    }
                }
                Alert("Please purchase to use this feature. Thanks", NotificationType.info);
                return RedirectToAction("DescriptionPayment");
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/CreateTrans
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateTrans(Transaction transaction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    transaction.TimeSend = DateTime.UtcNow;
                    if (_transactionServices.CreateTransactions(transaction))
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
                var searchUser = _userServices.GetUserByUsername(HttpContext.Session.GetString("username"));
                var model = new PaymentInfo
                {
                    UserId = searchUser.UserId,
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
                var search = _userServices.GetUserByUsername(username);
                if (search.IsSubcribeSend)
                {
                    return RedirectToAction("ChangeSubscribeSend");
                }
                if (!searchPayment.IsActive)
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
                var search = _userServices.GetUserByUsername(HttpContext.Session.GetString("username"));
                if (search != null)
                {
                    return View(search);
                }
                return RedirectToAction("Index", "Home");
            }
            Alert("You need Log in to access this page!", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/ChangeSubscribeSend
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChangeSubscribeSend(User search)
        {
            if (search != null)
            {
                if (_userServices.UpdateSubscribeSend(search))
                {
                    var searchEmailList = _emailListServices.GetEmailListByUsername(search.UserName);
                    if (searchEmailList != null)
                    {
                        if (_emailListServices.DeleteEmailList(searchEmailList.EmailId))
                        {
                            Alert("You are Unsubscribe Send Card successfully", NotificationType.success);
                            return RedirectToAction("Index", "Home");
                        }
                        Alert("Remove Email List failed", NotificationType.error);
                        return RedirectToAction("Index", "Home");
                    }
                    Alert("Not found Email List", NotificationType.error);
                    return RedirectToAction("Index", "Home");
                }
            }
            Alert("Unsubscribe Send Card failed", NotificationType.error);
            return RedirectToAction("Index", "Home");
        }

        //GET: User/EditSubscribe/5
        public IActionResult EditSubscribe(int id)
        {
            if (IsLoggedIn())
            {
                if (id > 0)
                {
                    var search = _userServices.GetUser(id);
                    if (search != null)
                    {
                        return View(search);
                    }
                    Alert("Not found User", NotificationType.error);
                    return RedirectToAction("Index");
                }
                Alert("UserId invalid", NotificationType.error);
                return RedirectToAction("Index");
            }
            Alert("You need Log in to access this page", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/AddEmailList
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddEmailList(EmailList emailList)
        {
            if (emailList.ListEmail != null)
            {
                string[] email = emailList.ListEmail.Split('\n');
                if (email.Length < 10 || email.Length > 20)
                {
                    Alert("You only input from 10 to 20 emails", NotificationType.error);
                    return RedirectToAction("SubscribeSend");
                }
                if (HttpContext.Session.GetString("username") != null)
                {
                    emailList.Username = HttpContext.Session.GetString("username").ToLower();
                    var search = _emailListServices.SearchEmailListByUsername(emailList.Username);
                    if (search.Count == 0)
                    {
                        if (_emailListServices.CreateEmailList(emailList))
                        {
                            var model = new User
                            {
                                UserName = emailList.Username,
                                IsSubcribeSend = true
                            };
                            if (_userServices.UpdateSubscribeSend(model))
                            {
                                Alert("You are Subscribe Send successfully", NotificationType.success);
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                _emailListServices.DeleteEmailList(emailList.EmailId);
                                Alert("Subscribe Send Failed. Please contact Administrator", NotificationType.error);
                                return RedirectToAction("SubscribeSend");
                            }
                        }
                    }
                    Alert("You has already register Email List", NotificationType.error);
                    return RedirectToAction("Index", "Home");
                }
            }
            Alert("Please do not empty fields", NotificationType.error);
            return RedirectToAction("SubscribeSend");
        }

        //GET: User/EditEmailList/5
        public IActionResult EditEmailList(string username)
        {
            if (IsLoggedIn())
            {
                if (username != null)
                {
                    var search = _emailListServices.GetEmailListByUsername(username);
                    if (search != null)
                    {
                        return View(search);
                    }
                    Alert("Not found Email List with this Username", NotificationType.error);
                    return RedirectToAction("Index");
                }
                Alert("Username was null", NotificationType.error);
                return View();
            }
            Alert("You need Log in to access this page!", NotificationType.warning);
            return RedirectToAction("Login", "Home");
        }

        //POST: User/EditEmailList
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditEmailList(EmailList editEmailList)
        {
            if (editEmailList != null)
            {
                var search = _emailListServices.GetEmailList(editEmailList.EmailId);
                if (search != null)
                {
                    editEmailList.ListEmail.Trim();
                    string[] ListEmail = editEmailList.ListEmail.Split('\n');
                    if (ListEmail.Length < 10 || ListEmail.Length > 20)
                    {
                        Alert("You must be enter from 10 to 20 emails.", NotificationType.error);
                        return View(search);
                    }
                    if (editEmailList == null)
                    {
                        if (_emailListServices.DeleteEmailList(editEmailList.EmailId))
                        {
                            Alert("Remove email list successfully", NotificationType.success);
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            Alert("Remove email list failed", NotificationType.error);
                            return View(search);
                        }
                    }
                    else
                    {
                        editEmailList.ListEmail = editEmailList.ListEmail.ToString();
                        if (_emailListServices.EditEmailList(editEmailList))
                        {
                            Alert("Update email list successfully", NotificationType.success);
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            Alert("Update email list failed", NotificationType.error);
                            return View(search);
                        }
                    }
                }
            }
            Alert("Model was null. Please try again", NotificationType.error);
            return RedirectToAction("Index");
        }

        //GET: User/SubscribeReceive
        public IActionResult SubscribeReceive()
        {
            if (IsLoggedIn())
            {
                var searchUser = _userServices.GetUserByUsername(HttpContext.Session.GetString("username").ToLower());
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
                if (search.IsActive)
                {
                    var searchUser = _userServices.GetUser(search.UserId);
                    if (searchUser != null)
                    {
                        searchUser.IsSubcribeReceive = true;
                        if (_userServices.UpdateSubscribeReceive(searchUser))
                        {
                            Alert("Subscribe Daily Receive New Card Successfully", NotificationType.success);
                            return RedirectToAction("Index", "Home");
                        }
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

        //POST: User/UnSubscribeReceive
        public IActionResult UnSubscribeReceive(User editUser)
        {
            var search = _userServices.GetUser(editUser.UserId);
            if (search != null)
            {
                search.IsSubcribeReceive = false;
                if (_userServices.UpdateSubscribeReceive(search))
                {
                    Alert("UnSubscribe daily receive new Cards successfully", NotificationType.success);
                    return RedirectToAction("Index", "Home");
                }
                Alert("UnSubscribe daily receive new Card failed", NotificationType.error);
                return RedirectToAction("SubscribeReceive");
            }
            Alert("Not found Username", NotificationType.error);
            return RedirectToAction("SubscribeReceive");
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