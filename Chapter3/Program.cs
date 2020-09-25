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
            var list = new List<string>()
            {
                "Tokyo","New Delhe","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };

            //list.ForEach(s => Console.WriteLine(s));

            list.ConvertAll(s => s.ToUpper()).ForEach(s => Console.WriteLine(s));                     

        }
    }
}
