using System;
using System.Collections.Generic;

namespace Product_Review_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management");
            List<ProductReview> productReviews = new List<ProductReview>() 
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4.5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 4,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 3,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 4.2, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 6, Rating = 4.1, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 3,   Review = "Good", isLike = true }

            };
         

            Managment managment = new Managment();
            managment.TopRecords(productReviews);
        }
    }
}
