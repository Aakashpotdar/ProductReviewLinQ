using System;
using System.Collections.Generic;

namespace ProductReviwe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Product> product = new List<Product>()
            {
                new Product { ProductId = 001, UserId = 01, Review = "Good", isLike = "Good", Rating = 7 },
            new Product() { ProductId = 002, UserId = 02, Review = "Good", isLike = "Good", Rating = 9 },
            new Product(){ ProductId = 003, UserId = 03, Review = "Bad", isLike = "No", Rating = 2 },
            new Product() { ProductId = 002, UserId = 04, Review = "Bad", isLike = "Good", Rating = 4 },
            new Product() { ProductId = 005, UserId = 05, Review = "Bad", isLike = "Good", Rating = 5 },
            new Product() { ProductId = 001, UserId = 06, Review = "Good", isLike = "Good", Rating = 6 },
            new Product() { ProductId = 004, UserId = 07, Review = "Bad", isLike = "Good", Rating = 6 },
            new Product() { ProductId = 002, UserId = 08, Review = "Good", isLike = "Good", Rating = 4 },
            new Product() { ProductId = 002, UserId = 09, Review = "Bad", isLike = "No", Rating = 1 },
            new Product() { ProductId = 04, UserId = 10, Review = "Bad", isLike = "Good", Rating = 2 },
        };
            ProductShowOprations productShow = new ProductShowOprations();

            productShow.Top3RecordsShow(product);
            productShow.SelectedRecords(product);
            productShow.RetrieveCountOfRecords(product);
            productShow.RetrieveRecordIdReview(product);
        }
    }
}
