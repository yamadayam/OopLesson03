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
            var text = "Cozy lummox gives smart squid who asks for job pen";
            text.ToArray();
            Exercise1_1(text);
            
        }
        static void Exercise1_1(string text) {            
            var dict = new SortedDictionary<char, int>();
            
            foreach (var item in text.ToUpper()) {
                if ('A' <= item && item <= 'Z') {
                    if (dict.ContainsKey(item)) {
                        dict[item]++;
                    } else {
                        dict[item] = 1;
                    }
                }
            }

            foreach (var item in dict) {
                Console.WriteLine("{0}：{1}", item.Key, item.Value);
            }

        }
    }
}
