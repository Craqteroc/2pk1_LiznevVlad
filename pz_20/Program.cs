using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_20
{
  
    internal class Program
    {
        static void stringULTRA(ref string data)
        {
            char[] rawData = data.ToCharArray();
            for (int i = 0; i < rawData.Length; i++)
            {
                if (char.IsLetter(rawData[i]))
                    rawData[i] = char.IsUpper(rawData[i]) ? char.ToLower(rawData[i]) : char.ToUpper(rawData[i]);
            }
            data = new string(rawData);
        }
        static void Main(string[] args)
        {
            string data = "";
            data = Console.ReadLine();
            stringULTRA(ref data);
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
    //class Person
    //    {
        
    //    private int Data;
    //    public string Name { get; set; }
    //    public int data
    //    {
            
    //        get { return Data; }------------------------------------------------ОЧЕНЬ СЫРОЕ ИСКЛЮЧЕНИЕ
    //        set
    //        {
    //            if (value == )
    //            {
    //                throw new Exception("Ввели неверное предложение");
    //            }
    //            else
    //            {
    //                Data = value;
    //            }
    //        }
    //    }

    //    }
}
