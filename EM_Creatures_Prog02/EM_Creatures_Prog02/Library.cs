using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_Creatures_Prog02
{
    public class Library
    {
        //print delegate
        public delegate void PrintPlatform(string message);
        public static PrintPlatform Print = PrintConsole;


        // platform specific print methods
        public static void PrintConsole(string message)
        {
            Console.Write(message);
        }

        public static void PrintWeb(string message)
        {

        }
    }
}
