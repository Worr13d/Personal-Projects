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
        private string direction;
        private int level;
        private Player player;


        public Dungeon(Player player)
        {
            rng = new Random();
            level = 0;
            direction = "forward";
            this.player = player;
        }




        /// <summary>
        /// 
        /// </summary>
        public void Continue()
        {
            switch (rng.Next(1, 4))
            {
                case 1:
                    Console.WriteLine("There is a fork in the cavern. You can go left or right. Which do you choose?");
                    direction = SmartConsole.PromptForInput(">", "left", "right");
                    ChooseRoom();
                    break;
                case 2:
                    Console.WriteLine("There is a fork in the cavern. You can go left, right, or straight. Which do you choose?");
                    direction = SmartConsole.PromptForInput(">", "left", "right", "straight");
                    ChooseRoom();
                    break;
                case 3:
                    Console.WriteLine("You continue down the narrow cave...");
                    SmartConsole.PromptForInput("Press Enter to continue...");
                    direction = "forward";
                    ChooseRoom();
                    break;
            }
            Console.WriteLine("You continue {0} down the cavern.", direction);
            level++;

        }

        /// <summary>
        /// Chooses events for picked room 
        /// Available events for rooms are
        /// * Nothing
        /// * Enemy
        /// * Shop
        /// * Chest
        /// * Instant Death
        /// * Hole
        /// ...
        /// </summary>
        /// <returns></returns>
        public void ChooseRoom()
        {
            switch (rng.Next(1, 11))
            {
                case 1:
                case 9:
                    Console.WriteLine("You found nothing of interest.");
                    SmartConsole.PromptForInput("Press Enter to continue...");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("You stumble upon an enemy!");
                    break;
                case 5:
                    Console.WriteLine("You found a shopkeep!");
                    // he is selling blah blah blah
                    break;
                case 6:
                    Console.WriteLine("You found a chest!");
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Red;
                    switch (rng.Next(1, 4))
                    {
                        case 1:
                            Console.WriteLine("A boulder rolls towards you from the end of the pathway!");
                            Console.WriteLine("You try and run away!");
                            if (rng.Next(1, 3) == 1)
                            {
                                Console.WriteLine("You barely manage to evade the boulder!!");
                            }
                            else
                            {
                                Console.WriteLine("You are flattened by the boulder and die.");
                                player.Health = 0;
                            }
                            break;
                        case 2:
                            Console.WriteLine("You trip and your head stams into a rock. You die.");
                            player.Health = 0;
                            break;
                        case 3:
                            Console.WriteLine("You weren't looking and fell down a hole. You die ");
                            player.Health = 0;
                            break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 8:
                    Console.WriteLine("You weren't looking and fell down a hole. You take 5 damage");
                    player.Health -= 5;
                    break;
                case 10:
                    Console.WriteLine("Nothing");
                    break;
            }
        }
    }
}
