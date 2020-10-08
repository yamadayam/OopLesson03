using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5 {
    class Program {
        static void Main(string[] args) {
#if false
#region 5.1
            Console.WriteLine("------5.1------");
            Console.Write("文字列１：");
            string str1 = Console.ReadLine();
            Console.Write("文字列２：");
            string str2 = Console.ReadLine();

            if ((string.Compare(str1, str2, true) == 0))
                Console.WriteLine("等しい");
            else
                Console.WriteLine("等しくない");
#endregion
#region 5.2
            Console.WriteLine("------5.2------");
            string str3 = Console.ReadLine();
            if (int.TryParse(str3, out int s1))
            {
                Console.WriteLine(s1.ToString("#,0.0000"));
            }
#endregion
#region 5.3
            //5.3.1
            Console.WriteLine("------5.1.3------");
            string str4 = "jackdaws love my big sphinx of quartz";
            var count = str4.Count(s => s == ' ');
            Console.WriteLine($"空白数 {0}",count);

            //5.3.2
            Console.WriteLine("big → small");
            var trace = str4.Replace("big", "small");
            Console.WriteLine(trace);

            //5.3.3
            var cou = str4.Split(' ').Count();            
            Console.WriteLine($"単語数 {0}",cou);

            //5.3.4
            var val = str4.Split(' ').Where(s=>s.Length<=4);
            Console.WriteLine("---4文字以下の単語---");
            foreach (var item in val)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
            
            //5.3.5
            var ss = str4.Split(' ').ToArray();
            var sb = new StringBuilder();
            foreach (var item in ss)
            {
                sb.Append(item+' ');
            }
            var tex = sb.ToString();
            Console.WriteLine(sb);
#endregion
#endif
#region 5.4
            Console.WriteLine("------5.4------");
            var text = "Novelist=谷口潤一郎;BestWork=春琴抄;Born=1886";
            var array = text.Split('=',';');

            Console.WriteLine("{0}:{1}", ToJapanese(array[0]), array[1]);
            Console.WriteLine("{0}:{1}", ToJapanese(array[2]), array[3]);
            Console.WriteLine("{0}:{1}", ToJapanese(array[4]), array[5]);
#endregion

        }
        static string ToJapanese(string key) {
            switch (key)
            {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生日";
                default:
                    return "        ";
            }
        }
    }
}
