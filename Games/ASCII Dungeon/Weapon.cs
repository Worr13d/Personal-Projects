using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Dungeon
{
    internal class Weapon
    {
        private string weaponName;
        private int weaponDamage;
        private string weaponType;

        public Weapon(string name, int weaponDamage, string weaponType)
        {
            weaponName = name;
            this.weaponDamage = weaponDamage;
            this.weaponType = weaponType;
        }
    }
}
