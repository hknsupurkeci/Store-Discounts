using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public enum Products { phone, computer, tv }
    internal class ProductManager
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Products ProductType { get; set; }
        public float Price { get; set; }
        public ProductManager(int productId, string productName, Products productType, float price)
        {
            ProductId = productId;
            ProductName = productName;
            ProductType = productType;
            Price = price;
        }
        public ProductManager() { }
    }
}
