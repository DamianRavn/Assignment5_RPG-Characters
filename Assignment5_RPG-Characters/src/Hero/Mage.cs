namespace Assignment5__RPG_Characters
{
    public class Mage : BaseHero
    {
        /// <summary>
        /// Creates a mage with the given parameters. Calls base constructor
        /// </summary>
        /// <param name="name">name of the mage</param>
        public Mage(string name) : base(name)
        {
            BaseAttributes = new PrimaryAttributes(1, 1, 8);
            levelUpAttributes = new PrimaryAttributes(1, 1, 5);
            RegisterUsableEquipment
                (new string[] {
                    WeaponType.STAFF.ToString(),
                    WeaponType.WAND.ToString(),
                    ArmorType.CLOTH.ToString()
                });
        }

        /// <summary>
        /// The attribute that boosts damage
        /// </summary>
        /// <returns>The attribute that boosts damage</returns>
        protected override int TotalPrimaryAttribute()
        {
            return TotalAttributes().Intelligence;
        }
    }
}