using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    internal class Player
    {

        // fields 

        private string name;
        private int health;
        private int money;
        private Weapon[] weapons;
        private Weapon weapon;
        private int score;
        // Constructor

        public Player()
        {
            name = "Player";
            health = 100;
            money = 0;
            weapons = new Weapon[10];
            weapons[0] = new Weapon("Stick", 2, "normal");
        }

        // Properties 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

    }
}
