using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreater
{
    public class Creater
    {
        

        static void Main(string[] args)
        {
            bool itBegins = true;
            while (itBegins)
            {

                Character newCharacter = new Character();
                Class newClass = new Class();
                Race newRace = new Race();


                Console.WriteLine("Welcome Adventurer");
                Console.WriteLine("\nLets create your character.");


                Console.WriteLine("\nFirst, name your character");
                string characterName = Console.ReadLine();
                newCharacter.EnterName(characterName);

                Console.WriteLine("\nSecond, Choose Your Race:");
                newRace.WhatRaceAreYou();
                //List<string> raceTypes = new List<string>();
                //raceTypes.Add("Human");
                //raceTypes.Add("Elf");
                //raceTypes.Add("Dwarf");
                //Console.WriteLine(raceTypes[0]);
                //Console.WriteLine(raceTypes[1]);
                //Console.WriteLine(raceTypes[2]);

                //string characterRace = Console.ReadLine().ToLower();
                //myCharacter.ChooseRace(characterRace);

                //switch (characterRace)
                //{
                //    case ("Human"):
                //        break;

                //    case ("Elf"):
                //        break;

                //    case ("Dwarf"):
                //        break;
                //}

                Console.WriteLine("\nThird, Choose Your Class:");
                newClass.WhatClassAreYou();
                //List<string> classType = new List<string>();
                //classType.Add("Fighter");
                //classType.Add("Mage");
                //classType.Add("Rouge");
                //Console.WriteLine(classType[0]);
                //Console.WriteLine(classType[1]);
                //Console.WriteLine(classType[2]);

                //string characterClass = Console.ReadLine().ToLower();
                //myCharacter.ChooseClass(characterClass);

                //if (characterClass == "fighter")
                //{
                //    classType.Add("Paladin");
                //}

                //Console.WriteLine(classType[3]);

                //switch (characterClass)
                //{
                //    case ("fighter"):
                //        Console.WriteLine("\nFighters use a sword and shield as weapons.");
                //        break;

                //    case ("mage"):
                //        Console.WriteLine("\nMages use a magic inate to them.");
                //        break;

                //    case ("rouge"):

                //        Console.WriteLine("\nRouges use a stealth and distance to fight.");
                //        break;
                //}


                Console.WriteLine("\nYou are a " + newCharacter.CharacterRace + " " + newCharacter.CharacterClass);
                Console.WriteLine("Enjoy your journey " + newCharacter.CharacterName);
                Console.WriteLine();

            }

        }
           
    }
}
