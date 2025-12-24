namespace ASCII_Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("Welcome to ASCII Dungeon.");
            Console.WriteLine("You find yourself stumbling upon a cavern. You have a burning desire to seize it. Something inside is calling you.");
            player.Name = SmartConsole.PromptForInput("\nWhat is your name? >");
            Console.WriteLine("You pick up a stick and head into the cavern.");

            Console.WriteLine("\n--- {0}'s journey begins. ---", player.Name);
            SmartConsole.PromptForInput("Press Enter to continue...");


        }
    }
}
