using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace StanfordAlgo
{
    class Program
    {
        static void Main(string[] args)
        {


            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();

            //char[] char1 = number1.ToCharArray();
            //char[] char2 = number2.ToCharArray();

     

            Console.WriteLine(Karatsuba.multiply(number1, number2));
        }




        //public static string multiply(string x, string y)
        //{
        //    Console.WriteLine(x+ " " + y);
        //    // x.y = 10^n ac + 10^(n/2) (a+b)(c+d) + bd
        //    BigInteger result;

        //    if (x.Length <= 2 && y.Length <= 2)
        //    {
        //        BigInteger multi = BigInteger.Parse(x) * BigInteger.Parse(y);
        //        result = multi;
        //    }
        //    else
        //    {
        //        int max = Math.Max(x.Length, y.Length) ;
        //        max += (max % 2);
        //        //int halfLen = Math.Abs(x.Length / 2);
        //        int halfLen = (max / 2) ;

        //            if (x.Length != max)
        //                x = x.PadLeft(x.Length + (max - x.Length), '0');
        //            if (y.Length != max)
        //                y = y.PadLeft(y.Length + (max - y.Length), '0');
               

        //        string a = x.Substring(0, halfLen);
        //        string b = x.Substring(halfLen, x.Length - halfLen);
        //        string c = y.Substring(0, halfLen);
        //        string d = y.Substring(halfLen, x.Length - halfLen);

        //        BigInteger e = BigInteger.Parse(a) + BigInteger.Parse(b);

        //        BigInteger f = BigInteger.Parse(c) + BigInteger.Parse(d);


        //        BigInteger step1 = BigInteger.Parse(multiply(a, c));
        //        BigInteger step2 = BigInteger.Parse(multiply(b, d));
        //        BigInteger step3 = BigInteger.Parse(multiply(e.ToString(), f.ToString())) - step1 - step2 ;

        //        double numLen = double.Parse(x.Length.ToString());
        //        Console.WriteLine(string.Format("{0} {1} {2}", step1,step2,step3));
        //        Console.WriteLine(string.Format("{0} {1}", numLen, halfLen));
        //        result = (BigInteger.Pow(10, halfLen*2) * step1) + (BigInteger.Pow(10, halfLen) * step3) + step2;
        //    }

        //    return result.ToString();
        //}

    }
}
