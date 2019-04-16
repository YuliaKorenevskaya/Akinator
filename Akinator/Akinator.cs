using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akinator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Загадайте число от 0 до 100.");
            Console.WriteLine("Это трёхзначное число?");
            string reply = Console.ReadLine();
            string yes = "да";

            if (yes == reply)
            {
                Console.WriteLine("Ваше число 100.");
                Environment.Exit(0);
            }

            Console.WriteLine("Это число чётное?");
            reply = Console.ReadLine();

            int[] number = new int[99];
            for (int i = 0; i < 99; ++i)
            {
                switch (i % 2)
                {
                    case 1://чётные
                        if (yes == reply)
                        {
                            number[i] = i + 1;
                        }
                        break;

                    case 0://нечётные
                        if (yes != reply)
                        {
                            number[i] = i + 1;
                        }
                        break;
                }
                //  Console.WriteLine($"{number[i]}");
            }

            Console.WriteLine("Чиcло кратно 3?");
            reply = Console.ReadLine();

            for (int i = 0; i < 99; ++i)
            {
                if (yes == reply & number[i] % 3 != 0 & number[i] != 0)// кратно
                {
                    number[i] = 0;
                }

                if (yes != reply & number[i] % 3 == 0 & number[i] != 0) // не кратно
                {
                    number[i] = 0;
                }
                // Console.WriteLine($"{number[i]}");
            }

            Console.WriteLine("Чиcло кратно 5?");
            reply = Console.ReadLine();

            for (int i = 0; i < 99; ++i)
            {
                if (yes == reply & number[i] % 5 != 0 & number[i] != 0)// кратно
                {
                    number[i] = 0;
                }

                if (yes != reply & number[i] % 5 == 0 & number[i] != 0) // не кратно
                {
                    number[i] = 0;
                }
                // Console.WriteLine($"{number[i]}");
            }

            Console.WriteLine("Число меньше 10?");
            reply = Console.ReadLine();

            if (yes == reply)//да
            {
                for (int i = 0; i < 9; ++i)
                {
                    if (number[i] != 0)
                    {
                        Console.WriteLine($"Ваше число {number[i]}?");
                        if (yes == Console.ReadLine())
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }

            else//нет
            {
                for (int i = 0; i < 99; ++i)
                {
                    if (i < 10)
                    {
                        number[i] = 0;
                    }
                    //Console.WriteLine($"{number[i]}");
                }
            }

            Console.WriteLine("Ваше число больше 55?");
            reply = Console.ReadLine();

            if (yes == reply)//да
            {
                for (int i = 0; i < 99; ++i)
                {
                    if (i <= 55)
                    {
                        number[i] = 0;
                    }
                    //Console.WriteLine($"{number[i]}");
                }
            }

            else//нет
            {
                for (int i = 0; i < 99; ++i)
                {
                    if (i > 55)
                    {
                        number[i] = 0;
                    }
                    //Console.WriteLine($"{number[i]}");
                }
            }

            Console.WriteLine("Сумма цифр числа больше 10?");
            reply = Console.ReadLine();
            int s = 0;

            for (int i = 0; i < 99; ++i)
            {
                s = number[i] % 10 + (number[i] - number[i] % 10) / 10;
                //Console.WriteLine($"{number[i]}-----{s}");

                if (yes == reply & number[i] != 0 & s > 10)
                {
                    Console.WriteLine($"Ваше число {number[i]}?");
                    if (yes == Console.ReadLine())
                    {
                        Environment.Exit(0);
                    }
                }

                if (yes != reply & number[i] != 0 & s <= 10)
                {
                    Console.WriteLine($"Ваше число {number[i]}?");
                    if (yes == Console.ReadLine())
                    {
                        Environment.Exit(0);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
