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
        public Cards CardType { get; set; }
        public bool AffiliateStore { get; set; } 
        public DateTime CreatedTime { get; set; }
        public CustomerManeger(int id, string userName, Cards cardType, bool affiliateStore, DateTime createdTime)
        {
            Id = id;
            CustomerName = userName;
            CardType = cardType;
            AffiliateStore = affiliateStore;
            CreatedTime = createdTime;
        }
        public CustomerManeger() { CardType = Cards.StandardCard; }
    }
}