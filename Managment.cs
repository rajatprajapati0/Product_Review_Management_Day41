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
                Console.WriteLine("ProductId: " + Pr.ProductId + " UserId: " + Pr.ProductId + " Rating: " + Pr.Rating + " Review: " + Pr.Review + " isLike: " + Pr.isLike+"\n");
            }
        }
        public void FilterRecord(List<ProductReview> ListproductReviews)
        {
            var recordedData = from ProductReviews in ListproductReviews where (ProductReviews.ProductId == 1 || ProductReviews.ProductId == 4 || ProductReviews.ProductId == 9) && ProductReviews.Rating > 3 select ProductReviews;
            foreach (var Pr in recordedData)
            {
                Console.WriteLine("ProductId: " + Pr.ProductId + " UserId: " + Pr.ProductId + " Rating: " + Pr.Rating + " Review: " + Pr.Review + " isLike: " + Pr.isLike+"\n");
            }
        }
        public void RetriveCountOfRecords(List<ProductReview> ListproductReviews)
        {
            var recordedData = ListproductReviews.GroupBy(x => x.ProductId).Select(x => new { productId = x.Key, count = x.Count() });
            foreach (var Pr in recordedData)
            {
                Console.WriteLine("ProductId: "+ Pr.productId  +" Count: " + Pr.count);
            }
        }
        public void RetriveIdandReviewRecords(List<ProductReview> ListproductReviews)
        {
            var recordedData = ListproductReviews.Select(x => new { productId = x.ProductId, review = x.Review });
            foreach (var Pr in recordedData)
            {
                Console.WriteLine("ProductId: " + Pr.productId + "  Review: " + Pr.review);
            }
        }
        public void RetriveSkipRecords(List<ProductReview> ListproductReviews)
        {
            var recordedData = ListproductReviews.Skip(5).ToList();
            foreach (var Pr in recordedData)
            {
                Console.WriteLine("ProductId: " + Pr.ProductId + " UserId: " + Pr.ProductId + " Rating: " + Pr.Rating + " Review: " + Pr.Review + " isLike: " + Pr.isLike + "\n");

            }
        }

    }
}
