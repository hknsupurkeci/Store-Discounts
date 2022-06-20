using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Basket
    {
        private List<ProductManager> Products = new List<ProductManager>();

        public Basket(List<ProductManager> products)
        {
            Products = products;
        }
        public Basket() { }
        
        // add to basket new product
        public void AddProduct(ProductManager product)
        {
            if(product != null)
                Products.Add(product);
        }
        // get products
        public List<ProductManager> GetProductManagers()
        {
            return Products;
        }
    }
}
