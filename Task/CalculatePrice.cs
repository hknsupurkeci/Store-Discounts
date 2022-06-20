using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class CalculatePrice
    {
        private CustomerManeger Customer { get; set; }
        private Basket Basket { get; set; }
        public CalculatePrice(Basket products, CustomerManeger customer)
        {
            Customer = customer;
            this.Basket = products;
        }
        // calculate invoice price
        public void InvoicePrice()
        {
            float discount = 0.0f;
            //step 1
            //max 3 option, because it can only take one
            switch (Customer.CardType)
            {
                case Cards.GoldCard:
                    //%30
                    discount = Discounts.GoldCardDiscount;
                    break;
                case Cards.SilverCard:
                    //%20
                    discount = Discounts.SilverCardDiscount;
                    break;
                case Cards.StandardCard:
                    //Check AffiliateStore
                    if (Customer.AffiliateStore)
                        discount = Discounts.AffiliateStore; //%10
                    else
                    {
                        //is the registration date less than 2 years ago
                        if (Customer.CreatedTime <= DateTime.Now.AddYears(-2))
                            discount = Discounts.CreateTime; //%5
                    }
                    break;
                default:
                    break;
            }
            //step 2 - 3
            Console.WriteLine("Last price: " + LastPrice(PercentageDiscount(discount)));
        }
        // the method by which percentage calculations are made
        private float PercentageDiscount(float discount)
        {
            List<ProductManager> Products = Basket.GetProductManagers();
            float totalPrice = 0;
            if(Products != null)
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].ProductType != Task.Products.phone)
                        totalPrice += (Products[i].Price - (Products[i].Price * discount));
                    else
                        totalPrice += Products[i].Price;
                }
            }
            return totalPrice;
        }
        // total price discount 
        private float LastPrice(float price)
        {
            if (Convert.ToInt32(price) / 200 != 0)
            {
                price -= ((Convert.ToInt32(price) / 200) * 5);
                return price;
            }
            else
                return price;
        }
    }
}
