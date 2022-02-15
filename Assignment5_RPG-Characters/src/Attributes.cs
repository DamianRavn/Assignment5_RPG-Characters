﻿namespace Assignment5__RPG_Characters
{
    public struct PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        /// <summary>
        /// Sets properties
        /// </summary>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="intelligence"></param>
        public PrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
        }

        /// <summary>
        /// Overloads the + operator. Add two attributes together to return a new attribute
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static PrimaryAttributes operator +(PrimaryAttributes a) => a;

        public static PrimaryAttributes operator +(PrimaryAttributes a, PrimaryAttributes b)
            => new PrimaryAttributes(a.Strength * b.Strength, a.Dexterity + b.Dexterity, a.Intelligence + b.Intelligence);
    }

    /// <summary>
    /// Data used to calculate damage with Weapon
    /// </summary>
    public struct WeaponAttributes
    {
        public int Damage { get; set; }
        public int AttackSpeed { get; set; }
    }
}