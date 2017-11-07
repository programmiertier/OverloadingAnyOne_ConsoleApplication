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
        // Object ist die oberste aller Klassen
        public static Object operator + (Super x, Super y)
        {
            WriteLine("Hier werden zwei Super Objekte addiert");
            // if (x.GetType() == typeof(Unter_1))
            WriteLine("erster Parameter als {0}", x.GetType());
            if (x.GetType().ToString() == "OverloadingAnyOne_ConsoleApplication_Unter1")
            {
                WriteLine("als Unter1 erkannt");
                return new Unter_1();
            }
            WriteLine("{0}", x.GetType());
            if (x.GetType().ToString() == "OverloadingAnyOne_ConsoleApplication_Unter2")
            {
                WriteLine("als Unter2 erkannt");
                return new Unter_2();
            }

            WriteLine("Rückgabe als Super Objekt");
            return new Super();
        }
    }

    class Unter_1 : Super
    {
        public static Unter_1 operator + (Unter_1 x, Unter_1 y)
        {
            WriteLine("Hier werden zwei Unter_1 Objekte addiert");
            return new Unter_1();
        }
    }

    class Unter_2 : Super
    {
        public static Unter_2 operator + (Unter_2 x, Unter_2 y)
        {
            WriteLine("Hier werden zwei Unter_2 Objekte addiert");
            return new Unter_2();
        }
    }
}
