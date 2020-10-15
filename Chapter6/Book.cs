using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// List 6-1

namespace Chapter06 {
    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }

    static class Books {
        public static List<Book> GetBooks() {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };
            //var books = new List<Book> {
            //   new Book { Title = "こころ", Price = 400, Pages = 378 },
            //   new Book { Title = "人間失格", Price = 281, Pages = 212 },
            //   new Book { Title = "伊豆の踊子", Price = 389, Pages = 201 },
            //   new Book { Title = "若草物語", Price = 637, Pages = 464 },
            //   new Book { Title = "銀河鉄道の夜", Price = 411, Pages = 276 },
            //   new Book { Title = "二都物語", Price = 961, Pages = 666 },
            //   new Book { Title = "遠野物語", Price = 514, Pages = 268 },
            //};
            return books;

        }
    }
}
