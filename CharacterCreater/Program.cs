using System;

namespace CharacterCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Adventurer");
            Console.WriteLine();

            
            Console.WriteLine("Add Character Name:");
            string charName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Choose Your Class:");
            Console.WriteLine("Fighter Mage Rouge");
            string className = Console.ReadLine();

            switch (className)
            {
                case "Fighter":
                    Console.WriteLine();
                    Console.WriteLine("Choose your background");
                    Console.WriteLine("Soldier Mercenary");
                    string backFighter = Console.ReadLine();
                    bool backSoldier = backFighter.Equals("Soldier");
                    if (backSoldier)
                    {
                        Console.WriteLine("Your weapon is a Sword and Shield.");
                    }
                    else
                    {
                        Console.WriteLine("Your weapon is a Long sword");
                    }
                    break;

                case "Rouge":
                    Console.WriteLine();
                    Console.WriteLine("Choose your background:");
                    Console.WriteLine("Thief Assassin");
                    string backRouge = Console.ReadLine();
                    break;

                case "Mage":
                    Console.WriteLine();
                    Console.WriteLine("Choose your background");
                    Console.WriteLine("Sorcerer Wizard");
                    string backMage = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Good Luck");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine(charName + " the " + className);
            Console.WriteLine("Enjoy your Journey");
        }
    }
}
