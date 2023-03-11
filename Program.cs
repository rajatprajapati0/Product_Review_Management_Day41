﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
                Console.WriteLine("Enter 0 : to end Program \n"+"Enter 1: for finding top 3 high rated product :- \nEnter 2 : for finding  product  above 3 ratings by product id :-\n");

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
                    default:
                        Console.WriteLine("enter right option\n");
                        break;


                }
            }


        }
    }
}
