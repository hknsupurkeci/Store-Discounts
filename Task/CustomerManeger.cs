using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public enum Cards { GoldCard, SilverCard, StandardCard }
    internal class CustomerManeger
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public Cards CardType { get; set; }
        public bool AffiliateStore { get; set; } 
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }
        public CustomerManeger(int id, string userName, string password, Cards cardType, bool affiliateStore, string email, DateTime createdTime)
        {
            Id = id;
            CustomerName = userName;
            Password = password;
            CardType = cardType;
            AffiliateStore = affiliateStore;
            Email = email;
            CreatedTime = createdTime;
        }
        public CustomerManeger() { CardType = Cards.StandardCard; }
    }
}