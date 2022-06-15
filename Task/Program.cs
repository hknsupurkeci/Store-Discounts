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
            CustomerManeger customer = new CustomerManeger(1, "hakan", "123456", Cards.GoldCard, false, "hakansupurkeci@gmail.com", DateTime.Now);

            ProductManager product = new ProductManager(1, "Xiaomi Note 11S", Products.phone, 8500);
            ProductManager product2 = new ProductManager(2, "Monster Abra A7", Products.computer, 18000);
            ProductManager product3 = new ProductManager(3, "Samsung 75Q60A", Products.tv, 9200);

            List<ProductManager> list = new List<ProductManager>() { product, product2, product3 };

            Basket basket = new Basket(list,customer);
            basket.InvoicePrice();

            Console.ReadLine();
        }
    }
}
