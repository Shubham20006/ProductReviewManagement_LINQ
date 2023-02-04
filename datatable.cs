using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class datatable
    {
        public static void Main(string[] args)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

            table.Rows.Add(1, 1, 4, "good", true);
            table.Rows.Add(4, 2, 2, "bad", false);
            table.Rows.Add(3, 5, 5, "good", true);
            table.Rows.Add(5, 3, 2, "bad", false);
            table.Rows.Add(1, 1, 3, "nice", true);
            table.Rows.Add(6, 6, 4, "good", true);
            table.Rows.Add(11, 2, 5, "good", true);
            table.Rows.Add(9, 4, 3, "nice", true);
            table.Rows.Add(3, 7, 4, "good", true);
            table.Rows.Add(2, 10, 1, "bad", false);
            table.Rows.Add(5, 3, 5, "good", true);
            table.Rows.Add(9, 5, 4, "good", true);
            table.Rows.Add(1, 1, 4, "good", true);
            table.Rows.Add(4, 2, 2, "bad", false);
            table.Rows.Add(3, 5, 5, "good", true);

            Display(table);
        }
        public static void Display(DataTable d)
        {
            var a = from p in d.AsEnumerable()
                    select new
                    {   productid = p.Field<string>("ProductID"),
                        userid = p.Field<string>("UserID"),
                        rating = p.Field<string>("Rating"),
                        review = p.Field<string>("Review"),
                        islike = p.Field<string>("isLike")
                    };
            foreach (var el in a)
            {
               if( el.islike.Contains("True"))
                {
                    Console.WriteLine(el);
                }
            }
        }
    }
}
