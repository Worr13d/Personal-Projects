using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    internal class SmartConsole
    {
        public static string PromptForInput(string input)
        {
            Console.Write(input);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ReadLine();
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
