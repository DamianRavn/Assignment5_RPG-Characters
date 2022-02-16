
using System;

namespace Assignment5__RPG_Characters
{
    /// <summary>
    /// A weapon is used to deal more damage. Implements the IWeapon interface.
    /// </summary>
    public class Weapon : IWeapon
    {
        public WeaponComponent WeaponComponent { get; set; }
        public ItemComponent ItemComponent { get; set; }

        /// <summary>
        /// This constructor creates the components in this entity
        /// </summary>
        /// <param name="name">name of the weapon</param>
        /// <param name="level">level of the weapon</param>
        /// <param name="type">which weapontype</param>
        /// <param name="baseDamage">damage of the weapon</param>
        /// <param name="attackSpeed">attack speed of the weapon</param>
        /// 
        public Weapon(string name, int level, WeaponType type, int baseDamage, float attackSpeed)
        {
            WeaponComponent = new WeaponComponent(type, baseDamage, attackSpeed);
            ItemComponent = new ItemComponent(name, level, ItemSlot.WEAPON);
        }

        /// <summary>
        /// What type of weapon is it?
        /// </summary>
        /// <returns>Weapon type as a string</returns>
        public string GetItemTypeAsString()
        {
            return WeaponComponent.WeaponType.ToString();
        }

        /// <summary>
        /// Returns the generic exception for this item
        /// </summary>
        /// <returns>InvalidWeaponException</returns>
        public Exception ItemException()
        {
            return new InvalidWeaponException();
        }

        /// <summary>
        /// Part of the requiements is to return this message. so here it is
        /// </summary>
        /// <returns>a message</returns>
        public string EquipMessage()
        {
            return "New weapon equipped!";
        }
    }
}
