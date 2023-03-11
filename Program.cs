using System;
using System.Collections.Generic;

namespace Product_Review_Management
{
    public class Program
    {
      public static  List<ProductReview> productReviews;
        static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management");
             productReviews = new List<ProductReview>() 
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4.5, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 4,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 4, Rating = 3,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 4.2, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 6, Rating = 4.1, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 7, Rating = 3,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 4, Rating = 4,   Review = "Good", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 4.9, Review = "Good", isLike = true },
                new ProductReview() { ProductId = 9, UserId = 6, Rating = 4.8, Review = "Nice", isLike = true },
                new ProductReview() { ProductId = 7, UserId = 7, Rating = 5,   Review = "Good", isLike = true }

            };
         

            Managment managment = new Managment();

            bool button = true;
            while (button)
            {
                Console.WriteLine("Enter 0 : to end Program \n"+"Enter 1: for finding top 3 high rated product :- " +
                    "\nEnter 2 : for finding  product  above 3 ratings and by product id :" +
                    "-\nENter 3 :Retrieve count of review present product Id"
                    + "-\nENter 4 :Retrieve only productID and review "
                    + "-\nENter 5 :skip top 5 records from the list"
                    + "-\nENter 6: Retriev data from Data table"
                     + "-\nENter 7:average rating of the each productId");



               int check =int.Parse(Console.ReadLine());
                switch (check)
                {

                    case 1:
                        managment.TopRecords(productReviews);
                        break;
                    case 2:
                        managment.FilterRecord(productReviews);
                        break;
                    case 0:
                        button= false;
                        break;
                    case 3:
                        managment.RetriveCountOfRecords(productReviews);
                        break;
                    case 4:
                        managment.RetriveIdandReviewRecords(productReviews);
                        break;
                    case 5:
                        managment.RetriveSkipRecords(productReviews);
                        break;
                    case 6:
                        managment.RetriveisLikeRecords();
                        break;
                    case 7:
                        managment.RetriveAverageRatingRecords(productReviews);
                        break;

                    default:
                        Console.WriteLine("enter right option\n");
                        break;


                }
            }


        }
    }
}
