using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreater
{
    class Race
    {
        public string raceName { get; set; }


        public void WhatRaceAreYou()
        {
            Character myCharacter = new Character();

            List<string> raceTypes = new List<string>();
            raceTypes.Add("Human");
            raceTypes.Add("Elf");
            raceTypes.Add("Dwarf");
            Console.WriteLine(raceTypes[0]);
            Console.WriteLine(raceTypes[1]);
            Console.WriteLine(raceTypes[2]);

            string characterRace = Console.ReadLine().ToLower();
            myCharacter.ChooseRace(characterRace);

            switch (characterRace)
            {
                case ("Human"):
                    break;

                case ("Elf"):
                    break;

                case ("Dwarf"):
                    break;
            }
        }
    }
}
