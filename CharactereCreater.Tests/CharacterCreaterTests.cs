using System;
using Xunit;

namespace CharacterCreater.Tests
{
    public class CharacterCreaterTests
    {
        [Fact]
        public void Can_Create_Character()
        {
            new Creater();
        }

        [Fact]
        public void Character_Has_Name()
        {
            Name charName = new Name();

            charName.firstName = myChar.CharName;

            Assert.Equal(charName.firstName);
        }

        [Fact]
        public void Character_Has_A_Class()
        {
            Class charClass = new Class();

            charClass.className = myChar.CharClass;

            Assert.Equal(charClass.className);
        }
    }
}
