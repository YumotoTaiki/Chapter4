using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {

    class YearMonth {

        //プロパティ
        public int Year { get; private set; }
        public int Month { get; private set; }
        public bool Is21Century {
            get {
                return 2001 <= Year && Year <= 2100;
            }
        }

        //コンストラクタ
        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }

        public YearMonth AddOnMonth() {
            var yearMonth = new YearMonth(this.Year, this.Month + 1);
            if (yearMonth.Month >= 12) {
                yearMonth.Year++;
                yearMonth.Month = 1;
            } else {
                yearMonth.Month++;
            }
            return yearMonth;
        }

        public override string ToString() {
            return $"{Year}年{Month}月";
        }
    }
}
