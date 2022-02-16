namespace Assignment5__RPG_Characters
{
    /// <summary>
    /// The warrior class
    /// </summary>
    public class Warrior : BaseHero
    {
        /// <summary>
        /// Creates a warrior with the given parameters. Calls base constructor
        /// </summary>
        /// <param name="name">name of the warrior</param>
        public Warrior(string name) : base(name)
        {
            BaseAttributes = new PrimaryAttributes(5, 2, 1);
            levelUpAttributes = new PrimaryAttributes(3, 2, 1);
            RegisterUsableEquipment
                (new string[] {
                    WeaponType.AXE.ToString(),
                    WeaponType.HAMMER.ToString(),
                    WeaponType.SWORD.ToString(),
                    ArmorType.MAIL.ToString(),
                    ArmorType.PLATE.ToString(),
                });
        }

        /// <summary>
        /// The attribute that boosts damage
        /// </summary>
        /// <returns>The attribute that boosts damage</returns>
        protected override int TotalPrimaryAttribute()
        {
            return TotalAttributes().Strength;
        }
    }
}