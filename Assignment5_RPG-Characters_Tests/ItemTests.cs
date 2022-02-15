using System;
using Xunit;
using Assignment5__RPG_Characters;

namespace Assignment5_RPG_Characters_Tests
{
    public class ItemTests
    {
        //equipping items
        [Fact]
        public void Equip_EquipHighLevelWeapon_InvalidWeaponException()
        {
            //Arrange
            Warrior warrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 2,
                ItemSlot = Slot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            //Act

            //Assert
        }
        [Fact]
        public void Equip_EquipHighLevelArmor_InvalidArmorException()
        {
            //Arrange
            Warrior warrior = new Warrior();
            Armour testPlateBody = new Armor()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 2,
                ItemSlot = Slot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
            //Act

            //Assert
        }
        [Fact]
        public void Equip_EquipWrongWeaponType_InvalidWeaponException()
        {
            //Arrange
            Warrior warrior = new Warrior();
            Weapon testBow = new Weapon()
            {
                ItemName = "Common bow",
                ItemLevel = 1,
                ItemSlot = Slot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_BOW,
                WeaponAttributes = new WeaponAttributes() { Damage = 12, AttackSpeed = 0.8 }
            };
            //Act

            //Assert
        }
        [Fact]
        public void Equip_EquipValidWeapon_SuccessMessage()
        {
            //Arrange
            string expected = "New weapon equipped!"; 
            Warrior warrior = new Warrior();
            Armour testClothHead = new Armor()
            {
                ItemName = "Common cloth head armor",
                ItemLevel = 1,
                ItemSlot = Slot.SLOT_HEAD,
                ArmourType = ArmourType.ARMOUR_CLOTH,
                Attributes = new PrimaryAttributes() { Intelligence = 5 }
            };
            //Act

            //Assert
        }
        [Fact]
        public void Equip_EquipValidArmor_SuccessMessage()
        {
            //Arrange
            string expected = "New armour equipped!";
            //Act

            //Assert
        }

        //Damage
        [Fact]
        public void Damage_CalculateDamageWithNoWeapon_ExpectedDamage()
        {
            //Arrange
            int expected = 1 * (1 + (5 / 100));
            Warrior warrior = new Warrior();
            //Act

            //Assert
        }
        [Fact]
        public void Damage_CalculateDamageWithValidWeapon_ExpectedDamage()
        {
            //Arrange
            int expected = (7 * 1.1) * (1 + (5 / 100));
            Warrior warrior = new Warrior();
            //Axe
            //Act

            //Assert
        }
        [Fact]
        public void Damage_CalculateDamageWithValidWeapon_ExpectedDamage()
        {
            //Arrange
            int expected = (7 * 1.1) * (1 + ((5 + 1) / 100));
            Warrior warrior = new Warrior();

            Armour testPlateBody = new Armor()
            {
                ItemName = "Common plate body armor",
                ItemLevel = 1,
                ItemSlot = Slot.SLOT_BODY,
                ArmourType = ArmourType.ARMOUR_PLATE,
                Attributes = new PrimaryAttributes() { Strength = 1 }
            };
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common axe",
                ItemLevel = 1,
                ItemSlot = Slot.SLOT_WEAPON,
                WeaponType = WeaponType.WEAPON_AXE,
                WeaponAttributes = new WeaponAttributes() { Damage = 7, AttackSpeed = 1.1 }
            };
            //Act

            //Assert
        }

    }
}
