

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

        /// <summary>
        /// Creates a piece of armor with the given parameters
        /// </summary>
        /// <param name="name">name of the armor</param>
        /// <param name="level">level of the armor</param>
        /// <param name="itemSlot">item slot</param>
        /// <param name="type">armor type</param>
        /// <param name="attributes">attributes the armor boosts</param>
        public Armor(string name, int level, ItemSlot itemSlot, ArmorType type, PrimaryAttributes attributes)
        {
            ArmorComponent = new ArmorComponent(type, attributes);
            ItemComponent = new ItemComponent(name, level, itemSlot);
        }

        /// <summary>
        /// What type of amor is it?
        /// </summary>
        /// <returns>Armor type as a string</returns>
        public string GetItemTypeAsString()
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

        /// <summary>
        /// Part of the requiements is to return this message. so here it is
        /// </summary>
        /// <returns>a message</returns>
        public string EquipMessage()
        {
            return "New armour equipped!";
        }
    }
}
