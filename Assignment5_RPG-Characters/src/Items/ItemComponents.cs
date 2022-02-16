namespace Assignment5__RPG_Characters
{
    //All enums that have to do with items
    public enum ItemSlot { WEAPON, BODY, HEAD, LEGS}
    public enum WeaponType { FISTS, AXE, BOW, DAGGER, HAMMER, STAFF, SWORD, WAND }
    public enum ArmorType { CLOTH, LEATHER, MAIL, PLATE }

    /// <summary>
    /// A Base item. Any item should have this component
    /// </summary>
    public struct ItemComponent
    {
        public string ItemName { get; set; }
        public int ItemLevel { get; set; }
        public ItemSlot ItemSlot { get; set; }

        /// <summary>
        /// Creates the item component with the given parameters
        /// </summary>
        /// <param name="itemName">name of the item</param>
        /// <param name="itemLevel">level of the item</param>
        /// <param name="itemSlot">item slot</param>
        public ItemComponent(string itemName, int itemLevel, ItemSlot itemSlot)
        {
            ItemName = itemName;
            ItemLevel = itemLevel;
            ItemSlot = itemSlot;
        }
        
    }

    /// <summary>
    /// A weapon component. Use it with weapons
    /// </summary>
    public struct WeaponComponent
    {

        public WeaponType WeaponType { get; set; }
        public WeaponAttributes WeaponAttributes { get; set; }
        
        /// <summary>
        /// Creates a weapon component with the given parameters
        /// </summary>
        /// <param name="type">weapontype</param>
        /// <param name="baseDamage">base damage</param>
        /// <param name="attackSpeed">attack speed</param>
        public WeaponComponent(WeaponType type, int baseDamage, float attackSpeed) : this()
        {
            WeaponType = type;
            WeaponAttributes = new WeaponAttributes(baseDamage, attackSpeed);
        }
    }

    /// <summary>
    /// An Armor component. Use it for armors
    /// </summary>
    public struct ArmorComponent
    {
        public ArmorType ArmorType { get; set; }
        public PrimaryAttributes Attributes { get; set; }

        /// <summary>
        /// Creates an armor component with the given parameters
        /// </summary>
        /// <param name="armourType">armor type</param>
        /// <param name="attributes">which attributes does this item boost</param>
        public ArmorComponent(ArmorType armourType, PrimaryAttributes attributes)
        {
            ArmorType = armourType;
            Attributes = attributes;
        }
    }
}