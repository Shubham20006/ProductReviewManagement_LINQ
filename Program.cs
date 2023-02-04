using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE 'PRODUCT REVIEW MANAGEMENT BY USING LINQ' PROGRAM.");

            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview(){ProductID=1, UserID=1, Rating=4, Review="good", isLike=true},
                new ProductReview(){ProductID=4, UserID=2, Rating=2, Review="bad", isLike=false},
                new ProductReview(){ProductID=3, UserID=5, Rating=5, Review="good", isLike=true},
                new ProductReview(){ProductID=5, UserID=3, Rating=2, Review="bad", isLike=false},
                new ProductReview(){ProductID=1, UserID=1, Rating=3, Review="nice", isLike=true},
                new ProductReview(){ProductID=6, UserID=6, Rating=4, Review="good", isLike=true},
                new ProductReview(){ProductID=11, UserID=2, Rating=5, Review="good", isLike=true},
                new ProductReview(){ProductID=9, UserID=4, Rating=3, Review="nice", isLike=true},
                new ProductReview(){ProductID=3, UserID=7, Rating=4, Review="good", isLike=true},
                new ProductReview(){ProductID=2, UserID=10, Rating=1, Review="bad", isLike=false},
                new ProductReview(){ProductID=5, UserID=3, Rating=5, Review="good", isLike=true},
                new ProductReview(){ProductID=9, UserID=5, Rating=4, Review="good", isLike=true},
                new ProductReview(){ProductID=1, UserID=1, Rating=4, Review="good", isLike=true},
                new ProductReview(){ProductID=4, UserID=2, Rating=2, Review="bad", isLike=false},
                new ProductReview(){ProductID=3, UserID=5, Rating=5, Review="good", isLike=true}
            };

            Management.retriveTopThreeByRating(list);
        }
    }
}