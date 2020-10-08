using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, -1, 6, 4, };
            Console.WriteLine($"平均値：{numbers.Average()}");
            Console.WriteLine($"合計値：{numbers.Sum()}");
            Console.WriteLine($"最小値：{numbers.Where(s=>s>0).Min()}");
            Console.WriteLine($"最大値：{numbers.Max()}");

            bool exists = numbers.Any(n => n % 7 == 0);

            var results = numbers.Where(n => n > 0).Take(5);
            foreach (var item in results)
            {
                Console.Write(item);
            }

            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格：{books.Average(s => s.Price)}");
            Console.WriteLine($"本の合計価格：{books.Sum(s => s.Price)}");
            Console.WriteLine($"本のページが最大：{books.Max(s=>s.Pages)}");
            Console.WriteLine($"高価な本：{books.Max(s => s.Price)}");
            Console.WriteLine($"タイトルに「物語」がある冊数：{books.Count(s=>s.Title.Contains("物語"))}");

            //600ページを超える書籍があるか？(Anyメソッド)
            Console.WriteLine();
            Console.Write("600ページを超える書籍:");
            Console.WriteLine(books.Any(s => s.Pages >= 600)?"ある":"なし");

            //すべてが200ページ以上の書籍か？(Allメソッド)
            Console.WriteLine();
            Console.Write("すべてが200ページ以上の書籍:");
            Console.WriteLine(books.All(s => s.Pages >= 200) ? "あります" : "ありません");

            //400ページを超える本は何冊目か?(FirstOrDefaltメソッド)
            Console.WriteLine();
            //var book = books.FirstOrDefault(s => s.Pages > 400);
            //int i;
            //for (i = 0; i < books.Count; i++)
            //{
            //    if (books[i].Title.Contains(book.Title))
            //    {
            //        break;
            //    }
            //}
            var count = books.FindIndex(x => x.Pages > 400);
            Console.WriteLine($"400ページを超える本は{count + 1}冊目");

            //本の値段が400円以上のものを3冊表示
            var result = books.Where(s => s.Price >= 400).Take(3);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Title}");
            }



        }
    }
}
