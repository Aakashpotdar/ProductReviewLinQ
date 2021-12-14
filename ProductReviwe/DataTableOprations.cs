using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProductReviwe
{
    public class DataTableOprations
    {
        public void RetriveDataIsLikeTrue(DataTable data)
        {
            var AllData = data.AsEnumerable();
            var info = from products in AllData
                       where (products.Field<bool>("isLike") == true)
                       select products.Field<int>("ProductId");
            foreach (var j in info)
            {
                Console.WriteLine("Product id which is liked : "+j);
            }
        }
        public void RetriveDataReviewIsNice(DataTable data)
        {
            var AllData = data.AsEnumerable();
            var info = from products in AllData
                       where (products.Field<string>("Review") == "Nice")
                       select products;
            Console.WriteLine("Product id which review is nice : ");
            foreach (var j in info)
            {
                Console.WriteLine("UserId: " + j.Field<int>("UserId")+ " review:" + j.Field<string>("Review")+ " product id:" + j.Field<int>("ProductId"));
            }
        }
        public void RetriveDataId10AndOrderByRating(DataTable data)
        {
            var AllData = data.AsEnumerable();
            var info = from products in AllData
                       where (products.Field<int>("UserId") == 010)
                       orderby (products.Field<int>("Rating"))
                       select products;

            Console.WriteLine("User id with 10 and which sorted by rating : ");
            foreach (var j in info)
            {
                Console.WriteLine("UserId: " + j.Field<int>("UserId") + " review:" + j.Field<string>("Review") + " product id:" + j.Field<int>("ProductId") + " Rating:" + j.Field<int>("Rating"));
            }
        }
    }
}
