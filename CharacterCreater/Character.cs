using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterCreater
{
    public class Character
    {
        public string CharName { get; set; }
        public string CharClass { get; set; }
        public string CharRace { get; set; }
        

        public void EnterName(string charName)
        {
            this.CharName = charName;
        }

        public void ChooseClass(string charClass)
        {
            this.CharClass = charClass;
        }

        public void ChooseRace(string charRace)
        {
            this.CharRace = charRace;
        }

    }
}
