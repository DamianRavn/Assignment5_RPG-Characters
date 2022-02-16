using Assignment5__RPG_Characters;
using Xunit;

namespace Assignment5_RPG_Characters_Tests
{
    public class ItemTests
    {
        //equipping items
        [Fact]
        public void Equip_EquipHighLevelWeapon_InvalidWeaponException()
        {
            //Arrange
            var hero = new Warrior("Gimli");
            var testAxe = new Weapon("Common axe", 2, WeaponType.AXE, 7, 1.1f);

            //Act
            //...

            //Assert
            Assert.Throws<InvalidWeaponException>(() => hero.Equip(testAxe));
        }
        [Fact]
        public void Equip_EquipHighLevelArmor_InvalidArmorException()
        {
            //Arrange
            var hero = new Warrior("Gimli");
            var testPlateBody = new Armor("Common plate body armor", 2, ItemSlot.BODY, ArmorType.PLATE, new PrimaryAttributes(1, 0, 0));

            //Act
            //...

            //Assert
            Assert.Throws<InvalidArmorException>(() => hero.Equip(testPlateBody));
        }
        [Fact]
        public void Equip_EquipWrongWeaponType_InvalidWeaponException()
        {
            //Arrange
            var hero = new Warrior("Gimli");
            var testBow = new Weapon("Common bow", 1, WeaponType.BOW, 12, 0.8f);

            //Act
            //...

            //Assert
            Assert.Throws<InvalidWeaponException>(() => hero.Equip(testBow));
        }
        [Fact]
        public void Equip_EquipValidWeapon_SuccessMessage()
        {
            //Arrange
            string expected = "New weapon equipped!";
            var hero = new Warrior("Gimli");
            var testAxe = new Weapon("Common axe", 1, WeaponType.AXE, 7, 1.1f);

            //Act
            string actual = hero.Equip(testAxe);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Equip_EquipValidArmor_SuccessMessage()
        {
            //Arrange
            string expected = "New armour equipped!";
            var hero = new Warrior("Gimli");
            var testPlateBody = new Armor("Common plate body armor", 1, ItemSlot.BODY, ArmorType.PLATE, new PrimaryAttributes(1, 0, 0));

            //Act
            string actual = hero.Equip(testPlateBody);

            //Assert
            Assert.Equal(expected, actual);
        }

        //Damage
        [Fact]
        public void Damage_CalculateDamageWithNoWeapon_ExpectedDamage()
        {
            //Arrange
            float expected = 1 * (1 + (5 / 100));
            var hero = new Warrior("Gimli");

            //Act
            var actual = hero.Damage();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_CalculateDamageWithValidWeapon_ExpectedDamage()
        {
            //Arrange
            float expected = (7 * 1.1f) * (1 + (5 / 100));
            var hero = new Warrior("Gimli");
            var testAxe = new Weapon("Common axe", 1, WeaponType.AXE, 7, 1.1f);

            //Act
            hero.Equip(testAxe);
            var actual = hero.Damage();

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Damage_CalculateDamageWithValidWeaponAndArmor_ExpectedDamage()
        {
            //Arrange
            float expected = (7 * 1.1f) * (1 + ((5 + 1) / 100));
            var hero = new Warrior("Gimli");
            var testAxe = new Weapon("Common axe", 1, WeaponType.AXE, 7, 1.1f);
            var testPlateBody = new Armor("Common plate body armor", 1, ItemSlot.BODY, ArmorType.PLATE, new PrimaryAttributes(1, 0, 0));

            //Act
            hero.Equip(testPlateBody);
            hero.Equip(testAxe);
            var actual = hero.Damage();

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
