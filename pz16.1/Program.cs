using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pz16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string t = Convert.ToString(Console.ReadLine());
            string s;
            s = t;
            while (s.Contains("  ")) 
            { 
                s = s.Replace("  ", " ");
                
            }
            s = s.ToLower();
            string[] c = s.Split(' ');

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i].Length > 1)
                {
                    c[i] = c[i].Substring(0, 1).ToUpper() + c[i].Substring(1, +c[i].Length - 1).ToLower();

                }
                else
                {
                    c[i] = c[i].ToUpper();
                }

            }
            File.AppendAllText(@"D: t1.txt", $"{s}");

            Console.ReadKey();
        }
    }
}
