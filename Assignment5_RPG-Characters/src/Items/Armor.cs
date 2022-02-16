

using System;

namespace Assignment5__RPG_Characters
{
    /// <summary>
    /// An armor is used to boost primary attributes. Implemets the IAmor interface
    /// </summary>
    public class Armor : IArmor
    {
        public ArmorComponent ArmorComponent { get; set; }
        public ItemComponent ItemComponent { get; set; }

        public Armor(string name, int level, ItemSlot itemSlot, ArmorType type, PrimaryAttributes attributes)
        {
            ArmorComponent = new ArmorComponent(type, attributes);
            ItemComponent = new ItemComponent(name, level, itemSlot);
        }
        /// <summary>
        /// What type of amor is it?
        /// </summary>
        /// <returns>Armor type as a string</returns>
        public string GetItemType()
        {
            return ArmorComponent.ArmorType.ToString();
        }

        /// <summary>
        /// Returns the generic exception for this item
        /// </summary>
        /// <returns>InvalidArmorException</returns>
        public Exception ItemException()
        {
            return new InvalidArmorException();
        }
    }
}
