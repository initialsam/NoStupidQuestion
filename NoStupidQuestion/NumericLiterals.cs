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
            var n2 = 10F;   //float     Single
            var n3 = 10D;   //double    Double
            var n4 = 10M;   //decimal   Decimal
            var n5 = 10U;   //uint      UInt32
            var n6 = 10L;   //long      Int64
            var n7 = 10UL;  //ulong     UInt64

            var temp1 = 50 / 100;
            Console.WriteLine(temp1);

            var temp2 = 50 / (100 * 1.0);
            Console.WriteLine(temp2);

            var temp3 = 50 / (100D);
            Console.WriteLine(temp3);

            n1.ToString();
            n2.ToString();
            n3.ToString();
            n4.ToString();
            n5.ToString();
            n6.ToString();
            n7.ToString();
        }
    }
}
