using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    internal class SmartConsole
    {
        public static  string PromptForInput(string input)
        {
            string temp;
            Console.Write(input);
            Console.ForegroundColor = ConsoleColor.Cyan;
            temp = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return temp;
        }
        public static string PromptForInput(string input, string answer1, string answer2)
        {
            string temp;
            do
            {
                Console.Write(input);
                Console.ForegroundColor = ConsoleColor.Cyan;
                temp = Console.ReadLine();
                if (temp != answer1 && temp != answer2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter either {0} or {1}", answer1, answer2);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (temp != answer1 && temp != answer2);
            Console.ForegroundColor = ConsoleColor.White;
            return temp;
        }

        public static string PromptForInput(string input, string answer1, string answer2, string answer3)
        {
            string temp;
            do
            {
                Console.Write(input);
                Console.ForegroundColor = ConsoleColor.Cyan;
                temp = Console.ReadLine();
                if (temp != answer1 && temp != answer2 && temp != answer3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter either {0}, {1}, or {2}", answer1, answer2, answer3);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (temp != answer1 && temp != answer2 && temp != answer3);
            Console.ForegroundColor = ConsoleColor.White;
            return temp;
        }
    }
}
