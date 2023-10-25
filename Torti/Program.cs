using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Torti;
namespace Torti
{
    class Program
    {
        static void Main(string[] args)
        {           
            int cena = Zakaz.summa;

            void punktitorta()
            {
                Console.Clear();
                Console.WriteLine("тортики v f.01");
                Console.WriteLine("  форма");
                Console.WriteLine("  размер");
                Console.WriteLine("  вкус коржей");
                Console.WriteLine("  кол-во коржей");
                Console.WriteLine("  глазурь");
                Console.WriteLine("  декор");
                Console.WriteLine("  конец заказа");
                Console.SetCursorPosition(0, 9);
                Console.WriteLine(Zakaz.forma + Zakaz.razmer + Zakaz.vkus + Zakaz.kolvo + Zakaz.glazur + Zakaz.dekor);
                Console.WriteLine("Цена: " + cena);
            podmenu();
            }
            punktitorta();
            void podmenu()
            {
            int pos = Strelki.strelki(1,7);

                if (pos == 1)
                {
                    Console.Clear();
                    Console.WriteLine("форма");
                    Console.WriteLine("  1.квадрат - 500\n  2.круг - 600\n  3.треугольник - 100");
                    int position = Strelki.strelki(1,3);
                    
                    if (position == 1)
                    {
                        Zakaz.forma = " квадрат ";
                        cena += 500;
                        punktitorta(); 
                    }
                    if (position == 2)
                    {
                        Zakaz.forma = " круг ";
                        cena += 600;
                        punktitorta();
                    }
                    if (position == 3)
                    {
                        Zakaz.forma = " треугольник ";
                        cena += 100;
                        punktitorta();
                    }
                }
                if (pos == 2)
                {
                    Console.Clear();
                    Console.WriteLine("размер");
                    Console.WriteLine("  1.большой - 500\n  2.средний - 200\n  3.маленький - 100");
                    int position = Strelki.strelki(1,3);
                    if (position == 1)
                    {
                        Zakaz.razmer = " большой ";
                        cena += 500;
                        punktitorta();
                    }
                    if (position == 2)
                    {
                        Zakaz.razmer = " средний ";
                        cena += 200;
                        punktitorta();
                    }
                    if (position == 3)
                    {
                        Zakaz.razmer = " маленький ";
                        cena += 100;
                        punktitorta();
                    }
                }
                if (pos == 3)
                {
                    Console.Clear();
                    Console.WriteLine("вкус коржей");
                    Console.WriteLine("  1.вкусный - 500\n  2.неоч - 700\n  3.вообще говно - 1000");
                    int position = Strelki.strelki(1,3);
                    if (position == 1)
                    {
                        Zakaz.vkus = " вкусный ";
                        cena += 500;
                        punktitorta();
                    }
                    if (position == 2)
                    {
                        Zakaz.vkus = " неоч ";
                        cena += 700;
                        punktitorta();
                    }
                    if (position == 3)
                    {
                        Zakaz.vkus = " вообще говно ";
                        cena += 1000;
                        punktitorta();
                    }
                }
                if (pos == 4)
                {
                    Console.Clear();
                    Console.WriteLine("количество коржей");
                    Console.WriteLine("  1.много - 200\n  2.мало - 300\n  3.3 - 100");
                    int position = Strelki.strelki(1, 3);
                    if (position == 1)
                    {
                        Zakaz.kolvo = " много ";
                        cena += 200;
                        punktitorta();
                    }
                    if (position == 2)
                    {
                        Zakaz.kolvo = " мало ";
                        cena += 300;
                        punktitorta();
                    }
                    if (position == 3)
                    {
                        Zakaz.kolvo = " 3 ";
                        cena += 100;
                        punktitorta();
                    }
                }
                if (pos == 5)
                {
                    Console.Clear();
                    Console.WriteLine("глазурь");
                    Console.WriteLine("  1.шоколад молочный - 300\n  2.шоколад белый - 400\n  3.без глаузри, хардкор - 100");
                    int position = Strelki.strelki(1, 3);
                    if (position == 1)
                    {
                        Zakaz.glazur = " молочный шоколад ";
                        cena += 300;
                        punktitorta();
                    }
                    if (position == 2)
                    {
                        Zakaz.glazur = " белый шоколад ";
                        cena += 400;
                        punktitorta();
                    }
                    if (position == 3)
                    {
                        Zakaz.glazur = " без глазури, хардкор ";
                        cena += 100;
                        punktitorta();
                    }
                }
                if (pos == 6)
                {
                    Console.Clear();
                    Console.WriteLine("декор");
                    Console.WriteLine("  1.авторский - 2500\n  2.свой - 0\n  3.базированный(со смурфиками) - 10000");
                    int position = Strelki.strelki(1, 3);
                    if (position == 1)
                    {
                        Zakaz.dekor = " авторский ";
                        cena += 2500;
                        punktitorta();
                    }
                    if (position == 2)
                    {
                        Zakaz.dekor = " свой ";
                        cena += 0;
                        punktitorta();
                    }
                    if (position == 3)
                    {
                        Zakaz.dekor = " базированный(со смурфиками) ";
                        cena += 10000;
                        punktitorta();
                    }
                }
                if (pos == 7)
                {
                    Console.Clear();
                    Console.WriteLine("Конец заказа");
                    Console.WriteLine("цена: " + cena);
                    Console.WriteLine("ваш торт:" + Zakaz.forma + Zakaz.razmer + Zakaz.vkus + Zakaz.kolvo + Zakaz.glazur + Zakaz.dekor);
                    Console.WriteLine("\n\nЕсли вы хотите сделать еще один заказ, нажмите Enter, если хотите выйти из программы, нажмите Escape");
                    ConsoleKeyInfo key = Console.ReadKey();

                    if(key.Key == ConsoleKey.Enter)
                    {
                        Zakaz.forma = " ";
                        Zakaz.razmer = " ";
                        Zakaz.vkus = " ";
                        Zakaz.kolvo = " ";
                        Zakaz.glazur = " ";
                        Zakaz.dekor = " ";
                        cena = 0;
                        punktitorta();
                    }
                    if (key.Key == ConsoleKey.Escape)
                    {
                        punktitorta();
                    }
                }
            }          
        }
    }
}