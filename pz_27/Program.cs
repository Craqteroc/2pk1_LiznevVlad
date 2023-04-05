using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    internal class Program
    {
        static public List<Marsh> Trafic = new List<Marsh>();
        static public Marsh marsh = new Marsh();

        static void Main(string[] args)
        {
            for(int i = 0; i != 8; i++)
            {
                Console.WriteLine("Введите начальное название маршрута");
                string Begst = Console.ReadLine();

                Console.WriteLine("Введите конечное название маршрута");
                string Term = Console.ReadLine();

                Console.WriteLine("Введите номер маршрута");
                int Numer = Convert.ToInt32(Console.ReadLine());

                marsh.Begst = Begst;
                marsh.Term = Term;
                marsh.Numer = Numer;

                Trafic.Add(marsh);

                Console.Clear();

            }
            
            Trafic.Sort(Sorter);

            foreach(Marsh mar in Trafic)
            {
                Console.WriteLine(mar.Begst + " " + mar.Term + " " + mar.Numer);
                
            }
            Console.ReadKey();
        }

        public static int Sorter(Marsh mar, Marsh mar1)
        {
            if (mar.Numer == 0)
            {
                if (mar1.Numer == 0)
                {
                    return 0;
                }

                else
                {
 
                    return -1;
                }
            }
            else
            {

                if (mar1.Numer == 0)
                {
                    return 1;
                }

                else
                { 
                    return mar.Numer.CompareTo(mar1.Numer);
                }
            }
        }
        
            
    }
    public struct Marsh
        {
        public int Numer;
        public string Begst;
        public string Term;
        }
}
