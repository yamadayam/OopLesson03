using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            YearMonth[] ymCollection = new YearMonth[5] 
            {new YearMonth(2000,12), new YearMonth(2020,12) , new YearMonth(1991,12) ,
             new YearMonth(1656,12) , new YearMonth(2008,12) };

            //4.2.2
            Console.WriteLine("------4.2.2------");
            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym);
            }
            //4.2.4
            Console.WriteLine("------4.2.4------");
            if (Is21find(ymCollection)==null)
            {
                Console.WriteLine("21世紀のデータはありません");
            } else
            {
                Console.WriteLine(Is21find(ymCollection));
            }
            //4.2.5
            Console.WriteLine("------4.2.5------");
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in ymCollection)
            {
                Console.WriteLine(array);
            }
        }
        //4.2.3
        static YearMonth Is21find(YearMonth[] yms) {
            foreach (var ym in yms)
            {
                if (ym.Is21Century)
                {
                    return ym;
                }
            }
            return null;
        }

    }
}
