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
                       where (products.Field<string>("isLike") == "true")
                       select products.Field<string>("ProductId");
            foreach (var j in info)
            {
                Console.WriteLine("Product id which is liked : "+j);
            }
        }
    }
}
