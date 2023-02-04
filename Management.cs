﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {

        public static void retriveTopThreeByRating(List<ProductReview> element)
        {
           
            var a = (from productreview  in element orderby productreview.Rating descending select productreview  ).Take(3);

            foreach (var i in a)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", i.ProductID, i.UserID, i.Rating, i.Review, i.isLike);
            }
        }
        public static void retriveByRatingandProductID(List<ProductReview> element)
        {

            var a = from productreview in element 
                     where (productreview.ProductID==1 || productreview.ProductID==4 || productreview.ProductID==9 )
                     && productreview.Rating > 3
                     select productreview;

            foreach (var i in a)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", i.ProductID, i.UserID, i.Rating, i.Review, i.isLike);
            }
        }
    }
}