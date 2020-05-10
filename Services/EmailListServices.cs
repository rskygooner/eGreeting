using eGreeting.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface IEmailListServices
    {
        EmailList GetEmailList(int id);
        EmailList GetEmailListByUsername(string username);
        List<EmailList> SearchEmailListByUsername(string username);
        bool CreateEmailList(EmailList emailList);
        bool EditEmailList(EmailList emailList);
        bool DeleteEmailList(int id);
    }
    public class EmailListServices : IEmailListServices
    {
        private readonly MariaDBContext _dbContext;

        public EmailListServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public EmailList GetEmailList(int id)
        {
            EmailList emailList =  _dbContext.EmailLists.Find(id);
            return emailList;
        }

        public EmailList GetEmailListByUsername(string username)
        {
            EmailList emailList = _dbContext.EmailLists.FirstOrDefault(o => o.Username == username);
            return emailList;
        }
        public List<EmailList> SearchEmailListByUsername(string username)
        {
            List<EmailList> emailLists = _dbContext.EmailLists.Where(item => item.Username == username).ToList();
            return emailLists;
        }
        public bool CreateEmailList(EmailList emailList)
        {
            _dbContext.EmailLists.Add(emailList);
            _dbContext.SaveChanges();
            return true;
        }

        public bool EditEmailList(EmailList editEmailList)
        {
            var search = GetEmailList(editEmailList.EmailId);
            if (search != null)
            {
                search.ListEmail = editEmailList.ListEmail;
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteEmailList(int id)
        {
            var b = GetEmailList(id);
            if (b != null)
            {
                _dbContext.EmailLists.Remove(b);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public IEnumerable<SelectListItem> GetEmail(string username)
        {
            var search = GetEmailListByUsername(username);
            if (search != null)
            {
                string[] email = search.ListEmail.Split('\n');
                var model = new List<SelectListItem>();
                foreach (var item in email)
                {
                    model.Add(new SelectListItem { Value = item.ToString(), Text = item.ToString() });
                }

                return model;
            }
            return null;
        }
    }
}
