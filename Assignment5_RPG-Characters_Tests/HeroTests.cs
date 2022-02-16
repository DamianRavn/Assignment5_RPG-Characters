using Assignment5__RPG_Characters;
using System;
using Xunit;

namespace Assignment5_RPG_Characters_Tests
{
    public class HeroTests
    {
        //Level tests
        [Fact]
        public void CharacterCreation_Level1_CorrectLevelOnCreation()
        {
            //Arrange
            int expected = 1;
            Ranger hero = new Ranger("Aragorn");

            //Act
            var actual = hero.Level;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUp_Level2_CorrectLevelOnLevelUp()
        {
            //Arrange
            int expected = 2;
            Ranger hero = new Ranger("Aragorn");

            //Act
            hero.LevelUp();
            var actual = hero.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        //Attribute tests
        [Fact]
        public void MageAttributes_DefaultAttributes_HaveCorrectAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(1, 1, 8);
            var hero = new Mage("Gandalf");

            //Act
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RogueAttributes_DefaultAttributes_HaveCorrectAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(2, 6, 1);
            var hero = new Rogue("Bilbo");

            //Act
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RangerAttributes_DefaultAttributes_HaveCorrectAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(1, 7, 1);
            var hero = new Ranger("Aragorn");

            //Act
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void WarriorAttributes_DefaultAttributes_HaveCorrectAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(5, 2, 1);
            var hero = new Warrior("Gimli");

            //Act
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void MageAttributes_LevelUpAttributes_HaveIncreasedAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(1+1, 1+1, 8+5);
            var hero = new Mage("Gandalf");

            //Act
            hero.LevelUp();
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RogueAttributes_LevelUpAttributes_HaveIncreasedAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(3, 10, 2);
            var hero = new Rogue("Bilbo");

            //Act
            hero.LevelUp();
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void RangerAttributes_LevelUpAttributes_HaveIncreasedAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(2, 12, 2);
            var hero = new Ranger("Aragorn");

            //Act
            hero.LevelUp();
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void WarriorAttributes_LevelUpAttributes_HaveIncreasedAttributes()
        {
            //Arrange
            var expected = new PrimaryAttributes(8, 4, 2);
            var hero = new Warrior("Gimli");

            //Act
            hero.LevelUp();
            var actual = hero.BaseAttributes;

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
