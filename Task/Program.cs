using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManeger customer = new CustomerManeger(1, "hakan", Cards.GoldCard, false, DateTime.Now);
            //--------------------------
            ProductManager product = new ProductManager(1, "Xiaomi Note 11S", Products.phone, 6700);
            ProductManager product2 = new ProductManager(2, "Monster Abra A7", Products.computer, 25000);
            ProductManager product3 = new ProductManager(3, "Samsung 75Q60A", Products.tv, 55000);
            //--------------------------
            List<ProductManager> productManagers = new List<ProductManager>() { product, product2, product3 };
            Basket basket = new Basket(productManagers);
            //--------------------------
            ProductManager product4 = new ProductManager(4, "Siemens 42'' PLAZMA TV HD", Products.tv, 22500);
            basket.AddProduct(product4);
            //--------------------------
            CalculatePrice calculatePrice = new CalculatePrice(basket,customer);
            calculatePrice.InvoicePrice();
            //--------------------------

            Basket basket1 = new Basket();
            basket1.AddProduct(product2);
            CalculatePrice calculatePrice1 = new CalculatePrice(basket1,customer);
            calculatePrice1.InvoicePrice();
            Console.ReadLine();
        }
    }
}
