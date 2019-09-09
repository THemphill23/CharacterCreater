using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreater
{
    public class Fighter
    {
        private string weapon;
        private string armor;
        
        public string Weapon
        {
            get { return this.Weapon; }
            set { this.Weapon = value; }
        }
        //Console.WriteLine("A tactical, front line attacker.");
        //Console.WriteLine("Your weapon is a Sword and Shield.");
    }
}
