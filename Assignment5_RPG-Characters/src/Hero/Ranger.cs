namespace Assignment5__RPG_Characters
{
    public class Ranger : BaseHero
    {
        /// <summary>
        /// Creates a ranger with the given parameters. Calls base constructor
        /// </summary>
        /// <param name="name">name of the ranger</param>
        public Ranger(string name) : base(name)
        {
            BaseAttributes = new PrimaryAttributes(1, 7, 1);
            levelUpAttributes = new PrimaryAttributes(1, 5, 1);
            RegisterUsableEquipment
                (new string[] {
                    WeaponType.BOW.ToString(),
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