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

            Console.WriteLine();
            Console.WriteLine("Choose your background:");
            Console.WriteLine("Noble, Street Kid, Wild");
            string backGround = Console.ReadLine();
            Console.WriteLine();

            switch (backGround)
            {
                case "Noble":
                    Console.WriteLine("Born in castle walls, you receieved the best training and the best life possible.");
                    Console.WriteLine("Once adulthood was reach, you were encouraged to explore beyond the walls of the castle.");
                    Console.WriteLine();
                    break;
                case "Street Kid":
                    Console.WriteLine("Born to a poor family, you survived in the city with whatever you could get.");
                    Console.WriteLine("Once you reached adulthood, you decide to explore beyond the city.");
                    Console.WriteLine();
                    break;
                case "Wild":
                    Console.WriteLine("You were born in a village outside the city.");
                    Console.WriteLine("Once you grew older you deccide to venture beyond the village into the world.");
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine("Choose Your Class:");
            Console.WriteLine("Fighter, Mage, Rouge");
            string className = Console.ReadLine();

            switch (className)
            {
                case "Fighter":
                    Console.WriteLine("Fighter: Straight into the fray attacker.");
                    Console.WriteLine("Choose your specilization");
                    Console.WriteLine("Soldier, Mercenary, Chosen");
                    string specFighter = Console.ReadLine();
                    bool specSoldier = specFighter.Equals("Soldier");
                    bool specChosen = specFighter.Equals("Chosen");
                    if (specSoldier)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your training came from a military school.");
                        Console.WriteLine("Now you use that training to help the land.");
                        Console.WriteLine("Your weapon is a Sword and Shield.");
                    }
                    else if (specChosen)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You believe to have been chosen by a god.");
                        Console.WriteLine("Now you use that power to help the land.");
                        Console.WriteLine("Your weapon is a Hammer.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You do whatever you can as long as it pays.");
                        Console.WriteLine("Your weapon is a Long sword");
                    }
                    break;

                case "Rouge":
                    Console.WriteLine("Rouge: Uses stealth and distance to deal damage.");
                    Console.WriteLine();
                    Console.WriteLine("Choose your specialization:");
                    Console.WriteLine("Thief, Assassin, Archer");
                    string specRouge = Console.ReadLine();
                    bool specThief = specRouge.Equals("Thief");
                    bool specArcher = specRouge.Equals("Archer");
                
                    if (specThief)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You lived by stealing and taking what you need.");
                        Console.WriteLine("That skill translated into a way to make a living.");
                        Console.WriteLine("Your weapon is a Whip.");
                    }
                    else if (specArcher)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You trained in sharpshooting and fighting from a distance.");
                        Console.WriteLine("This ability lead to many opportunities for you.");
                        Console.WriteLine("You weapon is a Bow and Arrows.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You were trained by a secret society to become a master killer.");
                        Console.WriteLine("You became good at what you do, which has lead to many jobs.");
                        Console.WriteLine("Your weapon is a Dagger");
                    }
                    break;

                case "Mage":
                    Console.WriteLine("Mage: Uses magic to deal damage and control the field.");
                    Console.WriteLine();
                    Console.WriteLine("Choose your specialization");
                    Console.WriteLine("Sorcerer, Wizard, Enchanter");
                    string specMage = Console.ReadLine();
                    bool specSorcerer = specMage.Equals("Sorcerer");
                    bool specEnchanter = specMage.Equals("Enchanter");
                    if (specSorcerer)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your were born with magical powers.");
                        Console.WriteLine("You sent time training to harness you power.");
                        Console.WriteLine("Once you grew up, you took your magic into the world.");
                    }
                    else if (specEnchanter)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your magical powers come from a magical item.");
                        Console.WriteLine("You received a fammily heirloom at a young age.");
                        Console.WriteLine("Once you determine the magical power of the heirloom, you thought to use it.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your studied to gain magical powers.");
                        Console.WriteLine("After years of schooling, you became a powerful magic wielder.");
                        Console.WriteLine("You have taken this magic and left school to see what's out in the world.");
                    }
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Good Luck");
                    break;
            }
          

            Console.WriteLine();
            Console.WriteLine(charName + " the " + backGround + " " + className);
            Console.WriteLine("Enjoy your Journey");
        }
    }
}
