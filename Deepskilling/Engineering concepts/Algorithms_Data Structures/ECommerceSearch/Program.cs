using System;

namespace ECommerceSearch
{
    class Program
    {
        // Linear Search
        static Product LinearSearch(Product[] products, int productId)
        {
            foreach (Product product in products)
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            return null;
        }

        // Binary Search
        static Product BinarySearch(Product[] products, int productId)
        {
            int low = 0;
            int high = products.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (products[mid].ProductId == productId)
                {
                    return products[mid];
                }
                else if (products[mid].ProductId < productId)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Mobile", "Electronics"),
                new Product(103, "Shoes", "Fashion"),
                new Product(104, "Watch", "Accessories"),
                new Product(105, "Bag", "Fashion")
            };

            int searchId = 103;

            Console.WriteLine(" Linear Search ");

            Product result = LinearSearch(products, searchId);

            if (result != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine("ID       : " + result.ProductId);
                Console.WriteLine("Name     : " + result.ProductName);
                Console.WriteLine("Category : " + result.Category);
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine();

            Console.WriteLine(" Binary Search ");

            result = BinarySearch(products, searchId);

            if (result != null)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine("ID       : " + result.ProductId);
                Console.WriteLine("Name     : " + result.ProductName);
                Console.WriteLine("Category : " + result.Category);
            }
            else
            {
                Console.WriteLine("Product Not Found");
            }
        }
    }
}