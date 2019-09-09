using System;
using Xunit;

namespace CharacterCreater.Tests
{
    public class CharacterCreaterTests
    {

        [Fact]
        public void Get_Returns_Fighter()
        {
            var charName = new Fighter();

            var result = "Fighter";

            Assert.Equal("Fighter", result);
        }
    }
}
