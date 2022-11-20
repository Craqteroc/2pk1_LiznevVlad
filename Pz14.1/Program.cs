using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz14._1
{
    internal class Program
    {
        public static double Sum(double z, double b)
        {

            z--;
            if (z == 0)
            {
                return b;
            }


            return Sum(z, b) + 0.1;
        }
        static double Sum2(double q, double w)
        {

            q--;
            if (q == 0)
            {
                return w;
            }
            return Sum2(q, w) * 0.15 + w;
        }
        static string Sum3(double y = 87)
        {
            
            if (y ==-87)
            { 
                return y.ToString() +"\r\n";
             }
            
            return Sum3(y - 1)+"" +y +"\r\n";

        }


        static void Main(string[] args)
        {
            string result3 = Sum3();
            double result2 = Sum2(10, 14);
            double result = Sum(10, 10);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadKey();
        }
    }
}
