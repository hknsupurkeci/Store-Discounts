using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Basket
    {
        public CustomerManeger Customer { get; set; }
        public List<ProductManager> Products { get; set; }

        public Basket(List<ProductManager> products, CustomerManeger customer)
        {
            Products = products;
            Customer = customer;
        }
        public void InvoicePrice()
        {
            float discount = 0.0f;
            //step 1
            //max 3 option, because it can only take one
            switch (Customer.CardType)
            {
                case Cards.GoldCard:
                    //%30
                    discount = 0.3f;
                    break;
                case Cards.SilverCard:
                    //%20
                    discount = 0.2f;
                    break;
                case Cards.StandardCard:
                    //Check AffiliateStore
                    if (Customer.AffiliateStore)
                        discount = 0.1f; //%10
                    else
                    {
                        //is the registration date less than 2 years ago
                        if (Customer.CreatedTime <= DateTime.Now.AddYears(-2))
                            discount = 0.05f; //%5
                    }
                    break;
                default:
                    break;
            }
            //step 2 - 3
            Console.WriteLine("Last price: " + LastPrice(PercentageDiscount(discount)));
        }
        public float PercentageDiscount(float discount)
        {
            float totalPrice = 0;
            for (int i = 0; i < Products.Count; i++)
            {
                if(Products[i].ProductType != Task.Products.phone)
                    totalPrice += (Products[i].Price - (Products[i].Price * discount));
                else
                    totalPrice += Products[i].Price;
            }
            return totalPrice;
        }
        public float LastPrice(float price)
        {
            if(Convert.ToInt32(price) / 200 != 0)
            {
                price -= ((Convert.ToInt32(price) / 200)*5);
                return price;
            }
            else
                return price;
        }
    }
}
