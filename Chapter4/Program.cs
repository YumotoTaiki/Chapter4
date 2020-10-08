using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            var YearMonths = new YearMonth[] {
                new YearMonth(1990,1),
                new YearMonth(1991,2),
                new YearMonth(1992,3),
                new YearMonth(1993,4),
                new YearMonth(1994,5),
            };

            //423
            Exercise2_2(YearMonths);

            ///424
            Console.WriteLine(FindFirst21C(YearMonths));
        }

        private static void Exercise2_2(YearMonth[] yearMonths){
            foreach (var ym in yearMonths) {
                Console.WriteLine(ym);
            }
        }

        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach (var ym in yms) {
                if (ym.Is21Century)
                    return ym;
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] ymCollection){
            var yearmonth = FindFirst21C(ymCollection);
            if (yearmonth == null) {
                Console.WriteLine("21世紀のデータはありません");
            } else {
                Console.WriteLine(yearmonth);
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection){
            var array = ymCollection.Select(ym => ym.AddOnMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }
    }
}
