using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OverloadingAnyOne_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();

            Unter_1 u1 = new Unter_1();

            Unter_2 u2 = new Unter_2();

            // u1 + u1;
            Unter_1 u1u1 = u1 + u1;

            // u1 + u2; // vorher Super u1u2, aber in Super.cs stand auch Super, nicht Object
            Object u1u2 = u1 + u2;

            // u2 + u2;
            Unter_2 u2u2 = u2 + u2;

            // u2 + u1;         // jetzt nicht das kommutativgesetz von zahlen  // möp möp
            Object u2u1 = u2 + u1;

            ReadLine();
            // wenn u1 auf u1 aufgeschrieben werden soll, geht dass
            // wenn aber u1 auf u2 geschrieben werden soll, dann nicht, weil gemischte, dann ja Object sind
            //u1 += u1;     // ist u1 = u1 + u1;

            // geht, weil Object
            // u1u2 = u1;

            // u1u2 += u1;     // weil kein Plusoperator zwischen Object unter Unter_1 definiert wurde

            // geht nicht, weil ich u2 nicht zwingen kann Unter_1 zu sein
            // u1 += (Unter_1)u2;

            

            ReadLine();
        }
    }
}
