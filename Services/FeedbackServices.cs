using eGreeting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace eGreeting.Services
{
    public interface IFeedbackServices
    {
        List<Feedback> GetAllFeedback();
        IPagedList<Feedback> GetAllFeedbackPaging(int page, int pageSize);
        Feedback GetFeedback(int id);
        bool CreateFeedback(Feedback feedback);
        bool EditFeedback(Feedback feedback);
        bool DeleteFeedback(int id);
    }
    public class FeedbackServices : IFeedbackServices
    {
        private readonly MariaDBContext _dbContext;

        public FeedbackServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Feedback> GetAllFeedback()
        {
            List<Feedback> feedbacks = _dbContext.Feedbacks.OrderByDescending(o => o.FeedbackId).ToList();
            return feedbacks;
        }

        public IPagedList<Feedback> GetAllFeedbackPaging(int page, int pageSize)
        {
            var feedbacks = _dbContext.Feedbacks.OrderByDescending(o => o.FeedbackId).ToPagedList(page, pageSize);
            return feedbacks;
        }

        public Feedback GetFeedback(int id)
        {
            Feedback feedback = _dbContext.Feedbacks.Find(id);
            return feedback;
        }

        public bool CreateFeedback(Feedback feedback)
        {
            try
            {
                _dbContext.Feedbacks.Add(feedback);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditFeedback(Feedback feedback)
        {
            try
            {
                _dbContext.Feedbacks.Update(feedback);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteFeedback(int id)
        {
            var b = GetFeedback(id);
            if (b != null)
            {
                _dbContext.Feedbacks.Remove(b);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
