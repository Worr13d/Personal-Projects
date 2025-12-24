using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    /// <summary>
    /// Adding this class for the sake of organization
    /// Could be implemented in Main Program but this is a lot neater
    /// </summary>
    internal class Dungeon
    {
        private Random rng;
        private int num;
        public Dungeon()
        {
            rng = new Random();

        }

        public void Continue()
        {
            num = rng.Next(1, 4);
            switch (num)
            {
                case 1:
                    Console.WriteLine("There is a fork in the cavern. You can go left or right. Which do you choose?");
                    SmartConsole.PromptForInput(">", "left", "right");
                    ChooseRoom();
                    break;
                case 2:
                    Console.WriteLine("There is a fork in the cavern. You can go left, right, or straight. Which do you choose?");
                    SmartConsole.PromptForInput(">", "left", "right", "straight");
                    ChooseRoom();
                    break;
            }


        }

        public string ChooseRoom()
        {
            return "work in progress";
        }
    }
}
