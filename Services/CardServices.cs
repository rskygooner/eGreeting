using eGreeting.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Services
{
    public interface ICardServices
    {
        List<Card> GetCards();
        List<Card> SearchCards(string nameCard);
        List<Card> GetCardsByCategory(string category);
        Card GetCard(int id);
        bool GetNameCard(string nameCard);
        bool GetImageCard(string imageName);
        bool CreateCard(Card card);
        bool EditCard(Card card);
        bool DeleteCard(int id);
    }
    public class CardServices : ICardServices
    {
        private readonly MariaDBContext _dbContext;

        public CardServices(MariaDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Card> GetCards()
        {
            List<Card> cards = _dbContext.Cards.OrderByDescending(x => x.DateCreated).ToList();
            return cards;
        }


        public List<Card> SearchCards(string nameCard)
        {
            List<Card> cards = _dbContext.Cards.Where(x => x.CardName.ToLower().Contains(nameCard.ToLower())).ToList();
            return cards;
        }

        public List<Card> GetCardsByCategory(string category)
        {
            if (category != null)
            {
                Category cate = _dbContext.Categories.SingleOrDefault(x => x.CategoryName.Equals(category));
                List<Card> cards = _dbContext.Cards.Where(x => x.CategoryId.Equals(cate.CategoryId)).ToList();
                return cards;
            }
            return GetCards();
        }


        public Card GetCard(int id)
        {
            Card card = _dbContext.Cards.Find(id);
            return card;
        }


        public bool GetNameCard(string nameCard)
        {
            var check = _dbContext.Cards.Any(x => x.CardName == nameCard);
            return check;
        }


        public bool GetImageCard(string imageName)
        {
            var check = _dbContext.Cards.Any(x => x.ImageName == imageName);
            return check;
        }


        public bool CreateCard(Card card)
        {
            var b = GetCard(card.CardId);
            if (b == null)
            {
                _dbContext.Cards.Add(card);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }


        public bool EditCard(Card card)
        {
            var b = GetCard(card.CardId);
            if (b != null)
            {
                if (card.ImageName != null)
                {
                    b.CardName = card.CardName;
                    b.CategoryId = card.CategoryId;
                    b.ImageName = card.ImageName;
                    b.DateCreated = card.DateCreated;
                }
                else
                {
                    b.CardName = card.CardName;
                    b.CategoryId = card.CategoryId;
                    b.DateCreated = card.DateCreated;
                }
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteCard(int id)
        {
            var b = GetCard(id);
            if (b != null)
            {
                _dbContext.Cards.Remove(b);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
