using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {

            int*[] y = new int*[2];
            Console.WriteLine("Введите первое число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int v = Convert.ToInt32(Console.ReadLine());

            y[0] = &c;
            y[1] = &v;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"в ячейке по адресу {(uint)y[i]} хранится значение: {(uint)*y[i]}");
            }
            Console.ReadKey();

        }
    }
}
