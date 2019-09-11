using System;

namespace CharacterCreater
{
    public class Creater
    {
        

        static void Main(string[] args)
        {
            Character myChar = new Character();

            Console.WriteLine("Welcome Adventurer");
            Console.WriteLine();
            Console.WriteLine("Lets create your character.");
            Console.WriteLine();

            
            Console.WriteLine("First, name your character");
            string charName = Console.ReadLine();
            myChar.EnterName(charName);
            Console.WriteLine();

            Console.WriteLine("Second, Choose Your Race:");
            Console.WriteLine("Human, Elf, Dwarf");
            string charRace = Console.ReadLine().ToLower();
            myChar.ChooseRace(charRace);

            switch (charRace)
            {
                case ("Human"):
                    break;

                case ("Elf"):
                    break;

                case ("Dwarf"):
                    break;
            }
            Console.WriteLine();



            Console.WriteLine("Third, Choose Your Class:");
            Console.WriteLine("Fighter, Mage, Rouge");
            string charClass = Console.ReadLine().ToLower();
            myChar.ChooseClass(charClass);

            switch (charClass)
            {
                 case ("fighter"):
                    Console.WriteLine("");
                    Console.WriteLine("Fighters use a sword and shield as weapons.");
                    break;

                case ("mage"):
                    Console.WriteLine("");
                    Console.WriteLine("Mages use a magic inate to them.");
                    break;

                case ("rouge"):
                    Console.WriteLine("");
                    Console.WriteLine("Rouges use a stealth and distance to fight.");
                    break;
            }
                
            


            Console.WriteLine();
            Console.WriteLine("You are a " + myChar.CharRace + " " + myChar.CharClass);
            Console.WriteLine("Enjoy your journey " + myChar.CharName);

            
        }
    }
}
