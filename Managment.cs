using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Product_Review_Management
{
    public class Managment
    {
        MDataTable MdataTable = new MDataTable();
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
       
        public void RetriveisLikeRecords()
        {

           
            var dataRow = MdataTable.dataTable.AsEnumerable().Where(x => x.Field<string>("isLike") == "True");
            foreach (DataRow row in dataRow)
            {
                Console.WriteLine("ProductId: " + row[0] + " UserId: " + row[1] + " Rating: " + row[2] + " Review: " + row[3] + " isLike: " + row[4] + "\n");


            }
        }
        public void RetriveAverageRatingRecords(List<ProductReview> ListproductReviews)
        {
            for (int i = 1; i < ListproductReviews.Count; i++)
            {
                foreach (var ProductReview in ListproductReviews)
                {
                    if (ProductReview.ProductId == i)
                    {
                        var recordedData = ListproductReviews.Where(x => x.ProductId == i).Average(x => x.Rating);
                        Console.WriteLine($"ProductId:"+ProductReview.ProductId+" AverageRating:"+ recordedData);
                    }
                }

            }
        }
        public void RetriveReviewContainsNiceRecords(List<ProductReview> ListproductReviews)
        {
            var recordedData = ListproductReviews.Where(x => x.Review.Contains("Nice"));
            foreach (var Pr in recordedData)
            {
                Console.WriteLine("ProductId: " + Pr.ProductId + " UserId: " + Pr.ProductId + " Rating: " + Pr.Rating + " Review: " + Pr.Review + " isLike: " + Pr.isLike + "\n");
            }
        }



    }
}
