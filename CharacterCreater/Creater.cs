using System;

namespace CharacterCreater
{
    public class Creater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Adventurer");
            Console.WriteLine();
            Console.WriteLine("Lets create your character.");
            Console.WriteLine();

            
            Console.WriteLine("First name your character");
            string charName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Second Choose Your Race:");
            Console.WriteLine("Human, Elf, Dwarf, Dragonborn");
            string charRace = Console.ReadLine();
            Console.WriteLine();



            Console.WriteLine("Third Choose Your Class:");
            Console.WriteLine("Fighter, Barbarian, Sorcerer, Wizard, Assassin, Archer");
            string className = Console.ReadLine();

            switch (className)
            {
                case "Fighter":
                    Console.WriteLine("A tactical, front line attacker.");
                    Console.WriteLine("Your weapon is a Sword and Shield.");
                    Console.WriteLine();
                    break;

                case "Barbarian":
                    Console.WriteLine("A straight into the battle attacker.");
                    Console.WriteLine("Your weapon is a Hammer.");
                    break;

                case "Sorcerer":
                    Console.WriteLine("Born with magic");
                    Console.WriteLine();
                    break;

                case "Wizard":
                    Console.WriteLine("Studied Magic");
                    Console.WriteLine();
                    break;

                case "Assassin":
                    Console.WriteLine("Uses stealth to deal damage.");
                    Console.WriteLine("Your weapon is a Dagger.");
                    Console.WriteLine();
                    break;

                case "Archer":
                    Console.WriteLine("Fights from a distance.");
                    Console.WriteLine("Your weapon is a Bow and Arrow.");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Good Luck");
                    break;
            }
           
            Console.WriteLine();
            Console.WriteLine("You are a " + charRace + " " + className);
            Console.WriteLine("Enjoy your journey " + charName);
        }
    }
}
