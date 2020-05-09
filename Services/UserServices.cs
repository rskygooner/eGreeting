using eGreeting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface IUserServices
    {
        List<User> GetUsers();
        User GetUser(int id);
        User CheckLogin(User user);
        User GetUserByUsername(string username);
        bool CreateUser(User user);
        bool EditUser(User editUser);
        bool DeleteUser(int id);
        bool UpdateIsVIP(User user);
        bool UpdateSubscribeReceive(User user);
        bool UpdateSubscribeSend(User user);
        bool ChangePassword(User user);
    }
    public class UserServices : IUserServices
    {
        private readonly MariaDBContext _dbContext;

        public UserServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetUsers()
        {
            List<User> users = _dbContext.Users.ToList();
            return users;
        }

        public User GetUser(int id)
        {
            User user = _dbContext.Users.Find(id);
            return user;
        }

        public User CheckLogin(User user)
        {
            User userLogin = _dbContext.Users.FirstOrDefault(item => item.UserName == user.UserName && item.Password == user.Password);
            return userLogin;
        }

        public User GetUserByUsername(string username)
        {
            User user = _dbContext.Users.FirstOrDefault(item => item.UserName == username);
            return user;
        }

        public bool CreateUser(User user)
        {
            var b = GetUser(user.UserId);
            if (b == null)
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditUser(User editUser)
        {
            var b = GetUser(editUser.UserId);
            if (b != null)
            {
                b.Password = editUser.Password;
                b.RePassword = editUser.RePassword;
                b.Role = editUser.Role;
                b.IsSubcribeSend = editUser.IsSubcribeSend;
                b.IsSubcribeReceive = editUser.IsSubcribeReceive;
                b.FullName = editUser.FullName;
                b.Gender = editUser.Gender;
                b.Phone = editUser.Phone;
                b.Email = editUser.Email;
                b.IsVIP = editUser.IsVIP;
                b.IsDeactive = editUser.IsDeactive;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public PaymentInfo GetUserPaymentInfo(int id)
        {
            PaymentInfo payment = _dbContext.PaymentInfos.Find(id);
            return payment;
        }

        public bool EditUserPaymentInfo(PaymentInfo paymentInfo)
        {
            var b = GetUserPaymentInfo(paymentInfo.UserId);
            if (b != null)
            {
                b.BankName = paymentInfo.BankName;
                b.BankAccount = paymentInfo.BankAccount;
                b.DateExpire = paymentInfo.DateExpire;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateIsVIP(User user)
        {
            var b = GetUser(user.UserId);
            if (b != null)
            {
                b.IsVIP = user.IsVIP;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateSubscribeReceive(User user)
        {
            var b = GetUser(user.UserId);
            if (b != null)
            {
                b.IsSubcribeReceive = user.IsSubcribeReceive;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateSubscribeSend(User user)
        {
            var b = GetUserByUsername(user.UserName);
            if (b != null)
            {
                b.IsSubcribeSend = user.IsSubcribeSend;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteUser(int id)
        {
            var b = GetUser(id);
            if (b != null)
            {
                _dbContext.Users.Remove(b);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ChangePassword(User user)
        {
            var c = GetUser(user.UserId);
            if (c != null)
            {
                c.Password = user.Password;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
