using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3 {
    class Program {
        //デリゲートの宣言(int型の因数を受け取ってbool値を返すメソッド)
        public delegate bool Judgement(int value);

        static void Main(string[] args) {
            var numbers = new List<int>()
            {
                12,87,94,14,53,20,40,35,76,91,31,17,48,
            };
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            Console.WriteLine(exists);

            numbers.ForEach(s => Console.WriteLine(s/2));

            var value = numbers.Where(s => s >= 50);
            foreach (var item in value)
            {
                Console.WriteLine(item);
            }

            var select = numbers.Select(s => s * 2).ToList();
            foreach (var item in select)
            {
                Console.WriteLine(item);
            }
        }
    }
}
