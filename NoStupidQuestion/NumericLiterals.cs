using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoStupidQuestion
{
    public static class NumericLiterals
    {
        public static void Suffix()
        {
            //var與匿名型別
            //https://dotblogs.com.tw/hatelove/archive/2012/04/20/var-and-anonymous-types-introduction.aspx

            var n1 = 10;    //int       Int32     
            var n3 = 10F;   //float     Single
            var n4 = 10D;   //double    Double
            var n5 = 10M;   //decimal   Decimal
            var n6 = 10U;   //uint      UInt32
            var n7 = 10L;   //long      Int64
            var n8 = 10UL;  //ulong     UInt64

            var b = 50 / 100;
            Console.WriteLine(b);
            var c = 50 / (100 * 1.0);
            Console.WriteLine(c);
            var e = 50 / (100D);
            Console.WriteLine(e);
        }
    }
}
