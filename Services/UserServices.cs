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
        User GetUser(string username);
        User CheckExistUser(string username, string email);
        User CheckLogin(User user);
        bool CreateUser(UserViewModel user);
        bool EditUser(User editUser);
        bool DeleteUser(string username);
        bool ChangePassword(ChangePasswordModel user);
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

        public User GetUser(string username)
        {
            User user = _dbContext.Users.Find(username);
            return user;
        }

        public User CheckExistUser(string username, string email)
        {
            User user = _dbContext.Users.SingleOrDefault(x => x.UserName == username || x.Email == email);
            return user;
        }

        public User CheckLogin(User user)
        {
            User userLogin = _dbContext.Users.FirstOrDefault(x => x.UserName == user.UserName && x.Password == user.Password);
            return userLogin;
        }

        public bool CreateUser(UserViewModel userView)
        {
            var user = new User
            {
                UserName = userView.UserName,
                Password = userView.Password,
                FullName = userView.FullName,
                Gender = userView.Gender,
                Phone = userView.Phone,
                Email = userView.Email
            };
            _dbContext.Add(user);
            _dbContext.SaveChanges();
            return true;
        }

        public bool EditUser(User editUser)
        {
            var b = GetUser(editUser.UserName);
            if (b != null)
            {
                b.Password = editUser.Password;
                b.FullName = editUser.FullName;
                b.Gender = editUser.Gender;
                b.Phone = editUser.Phone;
                b.Email = editUser.Email;
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
            var b = GetUserPaymentInfo(paymentInfo.PayId);
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


        public bool DeleteUser(string username)
        {
            var user = GetUser(username);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ChangePassword(ChangePasswordModel user)
        {
            var userEdit = GetUser(user.UserName);
            if (userEdit != null)
            {
                userEdit.Password = user.Password;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
