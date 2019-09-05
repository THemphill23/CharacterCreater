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
                    Console.WriteLine("Soldier Mercenary Chosen");
                    string backFighter = Console.ReadLine();
                    bool backSoldier = backFighter.Equals("Soldier");
                    bool backChosen = backFighter.Equals("Chosen");
                    if (backSoldier)
                    {
                        Console.WriteLine("Your weapon is a Sword and Shield.");
                    }
                    else if (backChosen)
                    {
                        Console.WriteLine("Your weapon is a Hammer.");
                    }
                    else
                    {
                        Console.WriteLine("Your weapon is a Long sword");
                    }
                    break;

                case "Rouge":
                    Console.WriteLine();
                    Console.WriteLine("Choose your background:");
                    Console.WriteLine("Thief Assassin Archer");
                    string backRouge = Console.ReadLine();
                    bool backThief = backRouge.Equals("Thief");
                    bool backArcher = backRouge.Equals("Archer");
                
                    if (backThief)
                    {
                        Console.WriteLine("Your weapon is a Whip.");
                    }
                    else if (backArcher)
                    {
                        Console.WriteLine("You weapon is a Bow and Arrows.");
                    }
                    else
                    {
                        Console.WriteLine("Your weapon is a Dagger");
                    }
                    break;

                case "Mage":
                    Console.WriteLine();
                    Console.WriteLine("Choose your background");
                    Console.WriteLine("Sorcerer Wizard Enchanter");
                    string backMage = Console.ReadLine();
                    bool backSorcerer = backMage.Equals("Sorcerer");
                    bool backEnchanter = backMage.Equals("Enchanter");
                    if (backSorcerer)
                    {
                        Console.WriteLine("Your have inate magical powers.");
                    }
                    else if (backEnchanter)
                    {
                        Console.WriteLine("Your magical powers come from a magical item.");
                    }
                    else
                    {
                        Console.WriteLine("Your studied to gain magical powers.");
                    }
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
