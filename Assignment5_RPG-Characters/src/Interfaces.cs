using System;

namespace Assignment5__RPG_Characters
{
    /// <summary>
    /// To be an item, you have to have the item component. Composition, opposed to inheritance.
    /// </summary>
    public interface IItem
    {
        public ItemComponent ItemComponent { get; set; }

        public string GetItemType();
        public Exception ItemException();
        //public T GetAttributes<T>();
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
