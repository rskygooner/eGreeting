using eGreeting.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface ISubscribleServices
    {
        List<SubscribeList> GetSubscribleList();
        List<SubscribeList> GetSubscribleListByUsername(string username);
    }
    public class SubscribleServices : ISubscribleServices
    {
        private readonly MariaDBContext _dbContext;

        public SubscribleServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SubscribeList> GetSubscribleList()
        {
            List<SubscribeList> subscribeLists = _dbContext.SubscribeLists.ToList();
            return subscribeLists;
        }

        public List<SubscribeList> GetSubscribleListByUsername(string username)
        {
            List<SubscribeList> subscribeLists = _dbContext.SubscribeLists.Where(x => x.Username == username).ToList();
            return subscribeLists;
        }

    }
}
