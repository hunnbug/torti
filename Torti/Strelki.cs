﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Torti
{
    internal class Strelki
    {
        public static int strelki(int min, int max)
        {
            int pos = 1;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != min)
                {
                    pos--;
                }
                if (key.Key == ConsoleKey.DownArrow && pos != max)
                {
                    pos++;
                }
                if(key.Key == ConsoleKey.Escape)
                {
                    Menu.punktitorta();
                }
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
