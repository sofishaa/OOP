// Онлайн-магазин
using System;
using System.Collections.Generic;

namespace Shop
{
    public class User
    {
        private int userId;
        private string username;
        private string email;

        public User(int id, string name, string email)
        {
            userId = id;
            username = name;
            this.email = email;
        }

        public int GetUserId()
        {
            return userId;
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetEmail()
        {
            return email;
        }
    }

    public class Product
    {
        private int productId;
        private string name;
        private double price;

        public Product(int id, string name, double price)
        {
            productId = id;
            this.name = name;
            this.price = price;
        }

        public int GetProductId()
        {
            return productId;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }
    }

    public class Order
    {
        private int orderId;
        private User user;
        private List<Product> products;

        public Order(int id, User user, List<Product> products)
        {
            orderId = id;
            this.user = user;
            this.products = products;
        }

        public int GetOrderId()
        {
            return orderId;
        }

        public User GetUser()
        {
            return user;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }

    public class Program
    {
        private static int staticField1 = 10;
        public static void Main(string[] args)
        {
            User user = new User(1, "SofiaHunkalo", "22fmif.s.hunkalo.com");

            Product product1 = new Product(1001, "Product 1", 10.99);
            Product product2 = new Product(1002, "Product 2", 19.99);
            Product product3 = new Product(1003, "Product 3", 7.99);

            List<Product> products = new List<Product>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            Order order = new Order(5001, user, products);

            Console.WriteLine("Order Details");
            Console.WriteLine("Order ID: " + order.GetOrderId());
            Console.WriteLine("User ID: " + order.GetUser().GetUserId());

            Console.WriteLine("Static Field 1: " + staticField1);
        }
    }
}
