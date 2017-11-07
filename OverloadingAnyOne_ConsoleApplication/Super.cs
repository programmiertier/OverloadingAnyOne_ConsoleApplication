using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OverloadingAnyOne_ConsoleApplication
{
    class Super
    {
        // statt in Unter_1 und Unter_2 die gleichen
        public static Super operator + (Super x, Super y)
        {
            WriteLine("Hier werden 2 Super Objekte addiert");
            return new Super();
        }
    }

    class Unter_1 : Super
    {
        public static Unter_1 operator + (Unter_1 x, Unter_1 y)
        {
            WriteLine("Hier werden 2 Unter_1 Objekte addiert");
            return new Unter_1();
        }
    }

    class Unter_2 : Super
    {
        public static Unter_2 operator + (Unter_2 x, Unter_2 y)
        {
            WriteLine("Hier werden 2 Unter_2 Objekte addiert");
            return new Unter_2();
        }
    }
}
