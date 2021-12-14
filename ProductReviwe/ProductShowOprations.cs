using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace ProductReviwe
{
    public class ProductShowOprations
    {
        public void Top3RecordsShow(List<Product> review)
        {
            var data = (from products in review
                       orderby products.Rating descending
                       select products).Take(3);

            foreach(Product i in data)
            {
                Console.WriteLine("User id: " + i.UserId + " Product Id: " + i.ProductId + " review: " + i.Review + " Product rateing: " + i.Rating + " like: " + i.isLike);
            }
        }
        public void SelectedRecords(List<Product> review)
        {
            var recordData = from productReviews in review
                             where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                             && productReviews.Rating > 3
                             select productReviews;

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductId + " " + "UserId: " + list.UserId + " " + "Rating: " + list.Rating + " "
                    + "Review: " + list.Review + " " + list.isLike + " ");
            }
        }

        public void RetrieveCountOfRecords(List<Product> review)
        {
            var recordData = review.GroupBy(x => x.ProductId).
                                    Select(x => new { ProductId = x.Key, Count = x.Count() });

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.ProductId + "-------------" + list.Count);
            }

        }

        public void RetrieveRecordIdReview(List<Product> review)
        {
            var data = from AllData in review
                       where(AllData.ProductId!=null&&AllData.Review!=null )
                       select AllData;

            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProductId + "            REVIEW: " + list.Review);
            }
        }
        public void RetrieveRecordSkipTop5(List<Product> review)
        {
            var data = (from AllData in review
                       where (AllData.ProductId != null)
                       select AllData).Skip(5);

            foreach (var list in data)
            {
                Console.WriteLine("ProductID: " + list.ProductId + "  user id: " + list.UserId + "  REVIEW: " + list.Review + "  rating: " + list.Rating);
            }
        }

    }
}
