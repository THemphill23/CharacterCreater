using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreater
{
    public class Character
    {
        public string CharacterName { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }
        

        public void EnterName(string characterName)
        {
            this.CharacterName = characterName;
        }


        public void ChooseRace(string characterRace)
        {
            this.CharacterRace = characterRace;
        }

        public void ChooseClass(string characterClass)
        {
            this.CharacterClass = characterClass;
        }

    }
}
