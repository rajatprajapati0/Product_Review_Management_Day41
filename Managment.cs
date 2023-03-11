using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Product_Review_Management
{
    public class Managment
    {
       
          
        public void TopRecords(List<ProductReview>  ListProductreviews) 
        {
            var recordedData = (from productReview in ListProductreviews
                                orderby productReview.Rating descending
                                select productReview).Take(3);
            foreach (var Pr in recordedData)
            {
                Console.WriteLine("ProductId: " + Pr.ProductId + " UserId: " + Pr.ProductId + " Rating: " + Pr.Rating + " Review: " + Pr.Review + " isLike: " + Pr.isLike);
            }
        }
    }
}
