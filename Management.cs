//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProductReviewManagement
//{
//    public class Management
//    {

//        public static void retriveTopThreeByRating(List<ProductReview> element)
//        {
           
//            var a = (from productreview  in element orderby productreview.Rating descending select productreview  ).Take(3);

//            foreach (var i in a)
//            {
//                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", i.ProductID, i.UserID, i.Rating, i.Review, i.isLike);
//            }
//        }
//        public static void retriveByRatingandProductID(List<ProductReview> element)
//        {

//            var a = from productreview in element 
//                     where (productreview.ProductID==1 || productreview.ProductID==4 || productreview.ProductID==9 )
//                     && productreview.Rating > 3
//                     select productreview;

//            foreach (var i in a)
//            {
//                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", i.ProductID, i.UserID, i.Rating, i.Review, i.isLike);
//            }
//        }
//        public static void retriveCountByProductID(List<ProductReview> element)
//        {

//            var a =  element.GroupBy(x => x.ProductID).Select(x => new { productid = x.Key, count = x.Count()});
            
//            foreach (var i in a)
//            {            
//                Console.WriteLine("ProductID :{0}, Count :{1}", i.productid, i.count);
//            }
//        }
//        public static void retriveProductIDAndReview(List<ProductReview> element)
//        {
//            var a = from productreview in element select productreview;

//            foreach (var i in a)
//            {
//                Console.WriteLine("ProductID :{0},  Review :{1}", i.ProductID, i.Review);
//            }
//        }
//        public static void skipTopFive(List<ProductReview> element)
//        {
//            var a = (from productreview in element select productreview).Skip(5);

//            foreach (var i in a)
//            {
//                Console.WriteLine("ProductID :{0},  Review :{1}", i.ProductID, i.Review);
//            }
//        }
//        public static void retriveProductIDAndReviewBySelect(List<ProductReview> element)
//        {
//            var a = element.AsEnumerable().Select(x=> new { productid = x.ProductID,review=x.Review});

//            foreach (var i in a)
//            {
//                Console.WriteLine("ProductID :{0},  Review :{1}", i.productid, i.review);
//            }
//        }

//    }
//}