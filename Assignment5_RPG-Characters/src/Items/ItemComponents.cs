namespace Assignment5__RPG_Characters
{
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

        public ArmorComponent(ArmorType armourType, PrimaryAttributes attributes)
        {
            ArmorType = armourType;
            Attributes = attributes;
        }
    }
}