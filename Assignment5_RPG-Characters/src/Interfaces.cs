﻿

namespace Assignment5__RPG_Characters
{
    /// <summary>
    /// To be an item, you simply have to have the item component. Composition, opposed to inheritance
    /// </summary>
    interface IItem
    {
        public ItemComponent ItemComponent { get; set; }

        public void Equip();
    }
    /// <summary>
    /// Weapon interface uses the item interface, because then every object that uses the weapon interface is forced to use the item interface aswell (Since weapon is an item, this makes sense)
    /// </summary>
    interface IWeapon : IItem
    {
        public WeaponComponent WeaponComponent { get; set; }
    }
    /// <summary>
    /// Armor interface uses the item interface, because then every object that uses the armor interface is forced to use the item interface aswell (Since armor is an item, this makes sense)
    /// </summary>
    interface IArmor : IItem
    {
        public ArmorComponent ArmorComponent { get; set; }
    }
}
