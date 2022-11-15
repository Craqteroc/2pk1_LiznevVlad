internal class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        while (i <= 3)
        {
            i++;

            Console.WriteLine("Введите значение a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение h");
            int h = Convert.ToInt32(Console.ReadLine());


            TriangleP(a, h);

        }
        Console.ReadKey();

    }
    static void TriangleP(double a, double h)
    {
        double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
        double Perimetr = 2 * b + a;
        Console.WriteLine($" периметр: {Perimetr}");


    }

}

