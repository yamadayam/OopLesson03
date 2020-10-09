using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
#if true
            #region 問題6-1
            //整数の例
            var numbers =
                new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35, };
            
            Console.WriteLine("------6.1.1------");
            Console.WriteLine($"最大値：{numbers.Max()}");
             
            Console.WriteLine("\n------6.1.2------");
            int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos))
            {
                Console.Write(number + ",");
            }
            
            Console.WriteLine("\n------6.1.3------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i].ToString() + ",");
            }
                        
            Console.WriteLine("\n------6.1.4------");
            var min = numbers.OrderBy(s => s).Take(3);
            foreach (var mn in min)
            {
                Console.Write(mn + ",");
            }
            
            Console.WriteLine("\n------6.1.5------");
            var disend = numbers.Distinct().Where(s => s > 10);
            foreach (var dis in disend)
            {
                Console.Write(dis + ",");
            }
            #endregion
#endif
#if true
            #region 問題6-2
            Console.WriteLine("\n------6.2.1------");
            var book = Books.GetBooks().Where(s => s.Title == "ワンダフル・C#ライフ" );
            foreach (var books in book)
            {
                Console.Write($"価格：{books.Price},ページ数：{books.Pages}");
            }
            
            Console.WriteLine("\n------6.2.2------");
            Console.WriteLine(Books.GetBooks().Where(s => s.Title.Contains("C#")).Count());
            
            Console.WriteLine("\n------6.2.3------");
            Console.WriteLine(Books.GetBooks().Where(s => s.Title.Contains("C#")).Select(s => s.Pages).Average());

            Console.WriteLine("\n------6.2.4------");
            var codes = Books.GetBooks().Where(s => s.Price >= 4000).Take(1).Select(s => s.Title);
            foreach (var code in codes)
            {
                Console.WriteLine(code);
            }

            Console.WriteLine("\n------6.2.5------");
            Console.WriteLine(Books.GetBooks().Where(s => s.Price < 4000).Max(s => s.Pages));

            Console.WriteLine("\n------6.2.6------");
            var orderPrice = Books.GetBooks().Where(s => s.Pages >= 400).OrderByDescending(s => s.Price);
            foreach (var price in orderPrice)
            {
                Console.WriteLine($"タイトル：{price.Title},ページ数{price.Price}");
            }

            Console.WriteLine("\n------6.2.7------");
            var titles = Books.GetBooks().Where(s => s.Title.Contains("C#")).Where(s => s.Pages <= 500);
            foreach (var title in titles)
            {
                Console.WriteLine($"{title.Title}");
            }


            #endregion
#endif
        }
    }
}
