namespace Assignment5__RPG_Characters
{
    public enum ItemSlot { WEAPON, BODY, HEAD, LEGS}
    public enum WeaponType { AXE, BOW, DAGGER, HAMMER, STAFF, SWORD, WAND }
    public enum ArmourType { CLOTH, LEATHER, MAIL, PLATE }

    /// <summary>
    /// A Base item. Any item should have this component
    /// </summary>
    public struct ItemComponent
    {
        public string ItemName { get; set; }
        public int ItemLevel { get; set; }
        public ItemSlot ItemSlot { get; set; }

        public ItemComponent()
        {
        }

        public ItemComponent(string name, int level, ItemSlot itemSlot)
        {
            this.name = name;
            this.level = level;
            this.itemSlot = itemSlot;
        }
    }

    /// <summary>
    /// A weapon component. Use it with weapons
    /// </summary>
    public struct WeaponComponent
    {
        public WeaponType WeaponType { get; set; }
        public WeaponAttribute WeaponAttribute { get; set; }
    }

    /// <summary>
    /// An Armor component. Use it for armors
    /// </summary>
    public struct ArmorComponent
    {
        public ArmourType ArmourType { get; set; }
        public PrimaryAttributes Attributes { get; set; }
    }
}