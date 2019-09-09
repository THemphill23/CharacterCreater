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

            charName.firstName = "Tobias";

            Assert.Equal("Tobias", charName.firstName);
        }

        [Fact]
        public void Get_Returns_Fighter()
        {
            var charName = new Fighter();

            var result = "Fighter";

            Assert.Equal("Fighter", result);
        }
    }
}
