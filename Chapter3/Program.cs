using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3 {
    class Program {
        //デリゲートの宣言(int型の因数を受け取ってbool値を返すメソッド)
        public delegate bool Judgement(int value);

        static void Main(string[] args) {
            var names = new List<string>()
            {
                "Tokyo","New Delhe","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };
            
            //3
            var whe = names.Where(s => s.Contains('o')).ToArray();
            foreach (var item in whe)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
