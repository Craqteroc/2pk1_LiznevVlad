using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pz_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string f1 = File.ReadAllText(@"D:text1.txt");
            string f2 = File.ReadAllText(@"D:text2.txt");
            
            File.WriteAllText(@"D:text3.txt", f1);
            
            File.WriteAllText(@"D:text2.txt",
                File.ReadAllText(@"D:text3.txt"));
            
            File.WriteAllText(@"D:text1.txt", f2);
            Console.ReadKey();
        }
    }
}
