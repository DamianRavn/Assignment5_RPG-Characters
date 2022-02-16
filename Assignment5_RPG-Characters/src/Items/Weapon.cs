
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


        public Weapon(string name, int level, ItemSlot itemSlot,  WeaponType type, int baseDamage, float attackSpeed)
        {
            WeaponComponent = new WeaponComponent(type, baseDamage, attackSpeed);
            ItemComponent = new ItemComponent(name, level, itemSlot);
        }

        //public T GetAttributes<T>()
        //{
        //    return (T)(object)WeaponComponent.WeaponAttributes;
        //}

        /// <summary>
        /// What type of weapon is it?
        /// </summary>
        /// <returns>Weapon type as a string</returns>
        public string GetItemType()
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
    }
}
