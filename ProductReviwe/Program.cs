using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviwe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Product> product = new List<Product>()
            {
                new Product { ProductId = 001, UserId = 01, Review = "Good", isLike = true, Rating = 7 },
            new Product() { ProductId = 002, UserId = 02, Review = "Good", isLike = true, Rating = 9 },
            new Product(){ ProductId = 003, UserId = 03, Review = "Bad", isLike = false, Rating = 2 },
            new Product() { ProductId = 002, UserId = 04, Review = "Bad", isLike = true, Rating = 4 },
            new Product() { ProductId = 005, UserId = 05, Review = "Bad", isLike = true, Rating = 5 },
            new Product() { ProductId = 001, UserId = 06, Review = "Good", isLike = true, Rating = 6 },
            new Product() { ProductId = 004, UserId = 07, Review = "Bad", isLike = false, Rating = 6 },
            new Product() { ProductId = 002, UserId = 08, Review = "Good", isLike = false, Rating = 4 },
            new Product() { ProductId = 002, UserId = 09, Review = "Bad", isLike = false, Rating = 1 },
            new Product() { ProductId = 04, UserId = 10, Review = "Bad", isLike = true, Rating = 2 },
        };
            ProductShowOprations productShow = new ProductShowOprations();

            //productShow.Top3RecordsShow(product);
            //productShow.SelectedRecords(product);
            //productShow.RetrieveCountOfRecords(product);
            //productShow.RetrieveRecordIdReview(product);
            //productShow.RetrieveRecordSkipTop5(product);



            DataTable table = new DataTable();

            table.Columns.Add("ProductId",typeof(int));
            table.Columns.Add("UserId", typeof(int));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            table.Columns.Add("Rating", typeof(int));

            table.Rows.Add(01, 001, "Nice", true, 8);
            table.Rows.Add(04, 002, "Nice", true, 9);
            table.Rows.Add(05, 003, "Bad", false,3);
            table.Rows.Add(02, 004, "Good", true, 7);
            table.Rows.Add(01, 005, "Good", true, 6);
            table.Rows.Add(03, 006, "Good", false,2);
            table.Rows.Add(05, 007, "Good", false,5);
            table.Rows.Add(02, 008, "Nice", true, 8);
            table.Rows.Add(02, 010, "Good", true, 7);
            table.Rows.Add(01, 010, "Good", true, 6);
            table.Rows.Add(03, 010, "Bad", false, 2);
            table.Rows.Add(05, 010, "Bad", false, 5);
            table.Rows.Add(02, 010, "Nice", true, 8);

            DataTableOprations obj = new DataTableOprations();
            obj.RetriveDataIsLikeTrue(table);
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            obj.RetriveDataReviewIsNice(table);
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            obj.RetriveDataId10AndOrderByRating(table);
        }
    }
}
