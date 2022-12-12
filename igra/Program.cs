using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace igra
{

    internal class Program
    {
        static string[] text1 = new string[] { "Правила игры: \r\n 1.За один раз игрок делает 1 ход. \r\n 2.Аптечка восстанавливает HP не имея срока времени. \r\n "+
         "3.Бафф действует только на 5 ходов, после 5 ходов он пропадает. " };
        static string[] text2 = new string[] { "Информация о игре:\r\n1.Игрок имеет изначально 30 HP и силу удара 5 HP.\r\n2.Аптечка восстанавливает 10 HP.\r\n"+
            "3.Враг имеет 15 HP и силу удара 5 HP.\r\n4.Бафф даёт усиление урона в 2 раза.\r\n5.Игра закончится когда все враги будут уничтожены.\r\n6.Цифра 1 - это игрок.\r\n" +
            "7.Цифра 2 - это враг.\r\n8.Цифра 3 - это аптечка.\r\n9.Цифра 4 - это бафф."  };
        static string[] text3 = new string[] { "Игра окончена." };
        
        static string[] texts = new string[] { "Сделай выбор оперции, выбирай стрелками вниз-вверх, что бы поддтвердить нажми - Ентер\n",
                "1 : Правила игры", "2 : Старт игры", "3 : Информация о игре","4 : Выход" };
        
        static void Main(string[] args)
        {

            Console.SetWindowSize(110, 50);
            foreach (string text in texts)
                Console.WriteLine(text);
            int num = Keys();
            switch (num)
            {
                case 1: { Console.WriteLine("выбор №1"); Console.ReadKey(); }; break;
                case 2: { Console.WriteLine("выбор №2"); Console.ReadKey(); }; break;
                case 3: { Console.WriteLine("выбор №3"); Console.ReadKey(); }; break;
                case 4: { Console.WriteLine("GameOver "); }; break;
            }
            Console.Clear();
            
                if (num == 2)
                {
                    xodba();


                }
                if (num == 1)
                {
                    foreach (string text in text1)
                        Console.WriteLine(text);
                    Console.SetWindowSize(110, 50);

                }

                if (num == 3)
                {
                    foreach (string text in text2)
                        Console.WriteLine(text);
                    Console.SetWindowSize(110, 50);

                }

                if (num == 4)
                {
                    Console.SetWindowSize(110, 50);
                    foreach (string text in text3)
                        Console.WriteLine(text);


                }

               

            Console.ReadKey();

            while (true)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.W)
                    {
                        break;
                    }
                    else if (key.Key == ConsoleKey.A)
                    {
                        break;
                    }
                    else if (key.Key == ConsoleKey.S)
                    {
                        break;
                    }
                    else if (key.Key == ConsoleKey.D)
                    {
                        break;
                    }

                }
            
        }
        
        static void xodba()
        {
                int[,] m = new int[25, 25];
                int[] pos = new int[4] {12,12, 30, 0};
                bool game = true;

                int u = 1;
                int g = 0;
                int h = 0;
                int v = 0;
            while (g != 10 && h != 5 && v != 3)
            {
                Thread.Sleep(10);
                var rand1 = new Random();
                    int value1 = rand1.Next(25);
                    var rand2 = new Random();
                    int value2 = rand2.Next(25);
                    var rand3 = new Random();
                    int value3 = rand1.Next(25);
                    var rand4 = new Random();
                    int value4 = rand2.Next(25);
                    var rand5 = new Random();
                    int value5 = rand1.Next(25);
                    var rand6 = new Random();
                    int value6 = rand2.Next(25);

                //while (g != 11)
                //{
                //    if (m[value1, value2] == 0)
                //        m[value1, value2] = 2;
                //    g++;
                //}
                //while (h != 6)
                //{
                //    if (m[value1, value2] == 0)
                //        m[value1, value2] = 3;
                //    h++;
                //}
                //while (g != 4)
                //{
                //    if (m[value1, value2] == 0)
                //        m[value1, value2] = 4;
                //    v++;
                //}

                if (m[value1, value2] == 0 && g != 10)
                {
                    m[value1, value2] = 2;
                    g++;

                }

                if (m[value3, value4] == 0 && h != 5)
                {
                    m[value3, value4] = 3;
                    h++;
                }

                if (m[value5, value6] == 0 && h != 3)
                {
                    m[value4, value5] = 4;
                    v++;
                }



            }

            for (int iRow = 0; iRow <= m.GetUpperBound(0); iRow += 1)
                {
                    for (int iCol = 0; iCol <= m.GetUpperBound(0); iCol += 1)
                    {
                        Console.Write(" {0} ", m[iRow, iCol]);
                    
                    m[12, 12] =  1 ;


                    }
                
                Console.WriteLine();
                }
            
            int e = 10;
            while (game == true)

            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.W)
                {
                    count++;
                    if (pos[0] != 0)
                    {
                        if (m[pos[0] - 1, pos[1]] == 2)
                        {
                            if (pos[3] == 0)
                            {
                                if (pos[2] - 15 > 0)
                                {
                                    pos[2] = pos[2] - 15;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }
                            else
                            {
                                pos[3] = pos[3] - 1;
                                if (pos[2] - 10 > 0)
                                {
                                    pos[2] = pos[2] - 10;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }

                        }
                        else if (m[pos[0] - 1, pos[1]] == 3)
                        {
                            pos[2] = 30;
                        }
                        else if (m[pos[0] - 1, pos[1]] == 4)
                        {
                            pos[3] = 5;
                        }
                        m[pos[0], pos[1]] = 0;
                        pos[0] = pos[0] - 1;
                        m[pos[0], pos[1]] = 1;
                        Console.Clear();
                        for (int iRow = 0; iRow <= m.GetUpperBound(0); iRow += 1)
                        {
                            for (int iCol = 0; iCol <= m.GetUpperBound(0); iCol += 1)
                            {
                                Console.Write(" {0} ", m[iRow, iCol]);
                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine(count);
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (key.Key == ConsoleKey.A)
                {
                    count++;
                    if (pos[1] != 0)
                    {
                        if (m[pos[0], pos[1] - 1] == 2)
                        {
                            if (pos[3] == 0)
                            {
                                if (pos[2] - 15 > 0)
                                {
                                    pos[2] = pos[2] - 15;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }
                            else
                            {
                                pos[3] = pos[3] - 1;
                                if (pos[2] - 10 > 0)
                                {
                                    pos[2] = pos[2] - 10;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }

                        }
                        else if (m[pos[0], pos[1] - 1] == 3)
                        {
                            pos[2] = 30;
                        }
                        else if (m[pos[0], pos[1] - 1] == 4)
                        {
                            pos[3] = 5;
                        }
                        m[pos[0], pos[1]] = 0;
                        pos[1] = pos[1] - 1;
                        m[pos[0], pos[1]] = 1;
                        Console.Clear();
                        for (int iRow = 0; iRow <= m.GetUpperBound(0); iRow += 1)
                        {
                            for (int iCol = 0; iCol <= m.GetUpperBound(0); iCol += 1)
                            {
                                Console.Write(" {0} ", m[iRow, iCol]);

                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine(count);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (key.Key == ConsoleKey.S)
                {
                    count++;
                    if (pos[0] != 24)
                    {
                        if (m[pos[0] + 1, pos[1]] == 2)
                        {
                            if (pos[3] == 0)
                            {
                                if (pos[2] - 15 > 0)
                                {
                                    pos[2] = pos[2] - 15;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }
                            else
                            {
                                pos[3] = pos[3] - 1;
                                if (pos[2] - 10 > 0)
                                {
                                    pos[2] = pos[2] - 10;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }
                        }
                        else if (m[pos[0] + 1, pos[1]] == 3)
                        {
                            pos[2] = 30;
                        }
                        else if (m[pos[0] + 1, pos[1]] == 4)
                        {
                            pos[3] = 5;
                        }
                        m[pos[0], pos[1]] = 0;
                        pos[0] = pos[0] + 1;
                        m[pos[0], pos[1]] = 1;
                        Console.Clear();
                        for (int iRow = 0; iRow <= m.GetUpperBound(0); iRow += 1)
                        {
                            for (int iCol = 0; iCol <= m.GetUpperBound(0); iCol += 1)
                            {
                                Console.Write(" {0} ", m[iRow, iCol]);

                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine(count);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (key.Key == ConsoleKey.D)
                {
                    count++;
                    if (pos[1] != 24)
                    {
                        if (m[pos[0], pos[1] + 1] == 2)
                        {
                            if (pos[3] == 0)
                            {
                                if (pos[2] - 15 > 0)
                                {
                                    pos[2] = pos[2] - 15;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }
                            else
                            {
                                pos[3] = pos[3] - 1;
                                if (pos[2] - 10 > 0)
                                {
                                    pos[2] = pos[2] - 10;
                                    e--;
                                    if (e == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Win");
                                        game = false;
                                        continue;
                                    }
                                }

                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("GameOver");
                                    game = false;
                                    continue;
                                }
                            }
                        }
                        else if (m[pos[0], pos[1] + 1] == 3)
                        {
                            pos[2] = 30;
                        }
                        else if (m[pos[0], pos[1] + 1] == 4)
                        {
                            pos[3] = 5;
                        }
                        m[pos[0], pos[1]] = 0;
                        pos[1] = pos[1] + 1;
                        m[pos[0], pos[1]] = 1;
                        Console.Clear();
                        for (int iRow = 0; iRow <= m.GetUpperBound(0); iRow += 1)
                        {
                            for (int iCol = 0; iCol <= m.GetUpperBound(0); iCol += 1)
                            {
                                Console.Write(" {0} ", m[iRow, iCol]);

                            }

                            Console.WriteLine();
                        }
                        Console.WriteLine(count);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (key.Key == ConsoleKey.C)
                {
                    string[] linesForTxt = new string[m.GetLength(0) + 1];
                    int[] product = Enumerable.Repeat(1, m.GetLength(1)).ToArray();

                    for (int i = 0; i < m.GetLength(0); i++)
                    {
                        int sum = 0;


                        for (int j = 0; j < m.GetLength(1); j++)
                        {

                            sum += m[i, j];


                            linesForTxt[i] += m[i, j] + " ";


                            product[j] *= m[i, j];
                        }
                        linesForTxt[i] += sum;
                        linesForTxt[linesForTxt.Length - 1] = string.Join(" ", product) + " X";


                        File.WriteAllText(@"E:\Программирование\result.txt", string.Join("\n", linesForTxt));
                        Console.Clear();
                        Console.WriteLine("Игра сохранена");
                    }
                    Console.ReadKey();
                }
                    

            }
            
            Console.ReadKey();

        }
        static int count = 0;
        static bool GameOver;
        static EActiv dir;
        enum EActiv
        {
            STOP = 0, LEFT, RIGHT, UP, DOWN
        }
        
        static void Text(int i)
        {
            if (i == 1)
            {
                Console.Clear();
                Console.WriteLine(texts[0]);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(texts[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(texts[2]);
                Console.WriteLine(texts[3]);
                Console.WriteLine(texts[4]);
            }
            if (i == 2)
            {
                Console.Clear();
                Console.WriteLine(texts[0]);
                Console.WriteLine(texts[1]);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(texts[2]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(texts[3]);
                Console.WriteLine(texts[4]);
            }
            if (i == 3)
            {
                Console.Clear();
                Console.WriteLine(texts[0]);
                Console.WriteLine(texts[1]);
                Console.WriteLine(texts[2]);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(texts[3]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(texts[4]);
            }
            if (i == 4)
            {
                Console.Clear();
                Console.WriteLine(texts[0]);
                Console.WriteLine(texts[1]);
                Console.WriteLine(texts[2]);
                Console.WriteLine(texts[3]);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(texts[4]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
        static int Keys()
        {
            int num = 0;
            bool flag = false;
            do
            {
                ConsoleKeyInfo keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow)
                {
                    num--;

                    Text(num);
                }
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {
                    num++;
                    Text(num);
                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    flag = true;
                }
                if (num == 0)
                {
                    num = 4;
                    Text(4);
                }
                if (num == 5)
                {
                    num = 1;
                    Text(1);
                }
            } while (!flag);
            return num;
        }
    }


}
            
    






            
        
    

    


