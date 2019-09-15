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
            Name characterName = new Name();

            characterName.firstName = "Joe";

            Assert.Equal("Joe", characterName.firstName);
        }

        //[Fact]
        //public void Character_Has_A_Class()
        //{
        //    Class charClass = new Class();

        //    charClass.className = myChar.CharClass;

        //    Assert.Equal("", charClass.className);
        //}
    }
}
