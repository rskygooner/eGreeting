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
            List<Card> cards = _dbContext.Cards.Where(x => x.NameCard.ToLower().Contains(nameCard.ToLower())).ToList();
            return cards;
        }


        public List<Card> GetCardsByCategory(string category)
        {
            if (category != null)
            {
                List<Card> cards = _dbContext.Cards.Where(x => x.Category.ToLower() == category.ToLower()).ToList();
                return cards;
            }
            return GetCards();
        }

        public static IEnumerable<SelectListItem> GetCategoryList()
        {
            var model = new List<SelectListItem>()
            {
                new SelectListItem{ Value="", Text="---Select Category---", Selected=true},
                new SelectListItem{ Value="birthday", Text="Birthday"},
                new SelectListItem{ Value="newyear", Text="NewYear"},
                new SelectListItem{ Value="festival", Text="Festival"},
            };
            return model;
        }

        public Card GetCard(int id)
        {
            Card card = _dbContext.Cards.Find(id);
            return card;
        }


        public bool GetNameCard(string nameCard)
        {
            var check = _dbContext.Cards.Any(x => x.NameCard == nameCard);
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
                    b.NameCard = card.NameCard;
                    b.Category = card.Category;
                    b.ImageName = card.ImageName;
                    b.DateCreated = card.DateCreated;
                }
                else
                {
                    b.NameCard = card.NameCard;
                    b.Category = card.Category;
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
