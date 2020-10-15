using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
    class MonthDay {
        public int Day { get; set; }
        
        public int Month { get; set; }
        
        public MonthDay(int day , int month) {
            Day = day;
            Month = month;
        }

        //Monthどうしの比較をする
        public override bool Equals(object obj) {
            //asでオブジェクトをキャスト
            var other = obj as MonthDay;
            if (other == null) {
                throw new ArgumentException(); 
            }
            return this.Day == other.Day && this.Month == other.Month;
        }

        //ハッシュコードを求める
        public override int GetHashCode() {
            return Month.GetHashCode()*31+Day.GetHashCode();
        }
        
    }
}
