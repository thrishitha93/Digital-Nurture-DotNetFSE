using System;

namespace ECommerceSearch
{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public string Category;

        public Product(int productId, string productName, string category)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
        }
    }
}