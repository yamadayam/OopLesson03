using Section01;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
    class Program {
        static void Main(string[] args) {
            var dict = new Dictionary<string, List<string>>() {
               { "PC", new List<string> { } },
               { "CD", new List<string> { } },
            };

            int host = 1;
            while (host==1) {
                Console.WriteLine("1．登録　2．内容を表示　3.終了");
                Console.Write(">");
                int reg = int.Parse(Console.ReadLine());
                Console.WriteLine();//改行

                switch (reg) {
                    case 1:
                        Console.Write("KEYを入力：");
                        string key = Console.ReadLine();

                        Console.Write("VALUEを入力：");
                        string value = Console.ReadLine();

                        if (dict.ContainsKey(key)) {
                            dict[key].Add(value);
                        } else {
                            dict[key] = new List<string> { value };
                        }
                        Console.WriteLine("登録しました！");
                        Console.WriteLine();//改行
                        break;
                    case 2:
                        foreach (var item in dict) {
                            foreach (var term in item.Value) {
                                Console.WriteLine("{0} : {1}", item.Key, term);
                            }
                        }
                        host = 2;
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                
            }

        }
    }
}
