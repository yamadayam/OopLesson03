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
            

            numbers.ForEach(s => Console.WriteLine(s/2));

            
        }
    }
}
