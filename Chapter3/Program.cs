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
            //1
            //var line = Console.ReadLine();
            //var index = names.FindIndex(s=>s==line);
            //Console.WriteLine(index);
            Console.WriteLine("\n--------3.2.1--------");
            Console.WriteLine("都市名を入力。空行で終了。");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            } while (true);

            //2
            Console.WriteLine("\n--------3.2.2--------");
            var value = names.Count(s => s.Contains('o'));
            Console.WriteLine(value);

            //3
            Console.WriteLine("\n--------3.2.3--------");
            var whe = names.Where(s => s.Contains('o')).ToArray();
            foreach (var item in whe)
            {
                Console.WriteLine(item);
            }
            //4
            Console.WriteLine("\n--------3.2.4--------");
            var sel = names.Where(s => s.StartsWith("B")).Select(s=>s.Length);
            foreach (var item in sel)
            {
                Console.WriteLine(item);
            }

        }
    }
}
