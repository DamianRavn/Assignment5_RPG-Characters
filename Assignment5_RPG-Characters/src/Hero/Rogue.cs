namespace Assignment5__RPG_Characters
{
    public class Rogue : BaseHero
    {
        /// <summary>
        /// Creates a rogue with the given parameters. Calls base constructor
        /// </summary>
        /// <param name="name">name of the rogue</param>
        public Rogue(string name) : base(name)
        {
            BaseAttributes = new PrimaryAttributes(2, 6, 1);
            levelUpAttributes = new PrimaryAttributes(1, 4, 1);
            RegisterUsableEquipment
                (new string[] {
                    WeaponType.DAGGER.ToString(),
                    WeaponType.SWORD.ToString(),
                    ArmorType.LEATHER.ToString(),
                    ArmorType.MAIL.ToString(),
                });
        }

        /// <summary>
        /// The attribute that boosts damage
        /// </summary>
        /// <returns>The attribute that boosts damage</returns>
        protected override int TotalPrimaryAttribute()
        {
            return TotalAttributes().Dexterity;
        }
    }
}
