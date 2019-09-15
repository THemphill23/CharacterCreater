using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreater
{
    public class Class
    {
        public string className { get; set; }


        public void WhatClassAreYou()
        {
            Character myCharacter = new Character();

            List<string> classType = new List<string>();
            classType.Add("Fighter");
            classType.Add("Mage");
            classType.Add("Rouge");
            Console.WriteLine(classType[0]);
            Console.WriteLine(classType[1]);
            Console.WriteLine(classType[2]);

            string characterClass = Console.ReadLine().ToLower();
            myCharacter.ChooseClass(characterClass);

            if (characterClass == "fighter")
            {
                classType.Add("Paladin");
            }

            Console.WriteLine(classType[3]);

            switch (characterClass)
            {
                case ("fighter"):
                    Console.WriteLine("\nFighters use a sword and shield as weapons.");
                    break;

                case ("mage"):
                    Console.WriteLine("\nMages use a magic inate to them.");
                    break;

                case ("rouge"):

                    Console.WriteLine("\nRouges use a stealth and distance to fight.");
                    break;
            }
        }

    }

}
