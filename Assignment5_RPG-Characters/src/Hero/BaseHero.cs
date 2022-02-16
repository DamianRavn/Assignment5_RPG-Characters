using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5__RPG_Characters
{
    /// <summary>
    /// This should be the base of all new heroes.
    /// </summary>
	public abstract class BaseHero
	{
        public string Name { get; set; }
        public int Level { get; set; }
        public PrimaryAttributes BaseAttributes { get; set; }
        private Weapon defaultWeapon;

        protected PrimaryAttributes levelUpAttributes;
        protected HashSet<string> usableEquipment;

        public Dictionary<ItemSlot, IItem> Equipment { get; set; }


        /// <summary>
        /// Initializes the Equipment Dictionary and defaultWeapon, and adds defaultWeapon to equipment
        /// </summary>
        public BaseHero()
		{
            Equipment = new Dictionary<ItemSlot, IItem>();
            //makes calculating the damage easier if the hero has a weapon on creation, so i added the fist weapon.
            var defaultWeapon = new Weapon("fist", 1, WeaponType.FISTS, 1, 1);
            Equipment.Add(ItemSlot.WEAPON, defaultWeapon);
        }

        /// <summary>
        /// Creates the hero with a name.
        /// </summary>
        /// <param name="name">name of the hero</param>
        public BaseHero(string name) : this()
        {
            Name = name;
            Level = 1;
        }

        /// <summary>
        /// Each hero has their own main attribute they use to increase damage.
        /// </summary>
        /// <returns>Total Main attribute</returns>
        protected abstract int TotalPrimaryAttribute();

        protected PrimaryAttributes TotalAttributes()
        {
            PrimaryAttributes armorAttr = EquippedItemsAttr();
            return BaseAttributes + armorAttr;
        }

        /// <summary>
        /// One level up. Increases Level and BaseAttributes
        /// </summary>
        public void LevelUp()
        {
            Level += 1;
            BaseAttributes += levelUpAttributes;
        }

        /// <summary>
        /// Calculate the damage
        /// </summary>
        /// <returns>Damage dealt</returns>
        public float Damage()
        {
            Weapon weapon;
            //In case that a item was somehow equipped to the weapon slot
            try
            {
                weapon = (Weapon)Equipment[ItemSlot.WEAPON];
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("How did you equip a non-weapon to the weaponslot?? " + e.Message);
                Equipment[ItemSlot.WEAPON] = defaultWeapon;
                weapon = defaultWeapon;
            }
            
            var weaponAttr = weapon.WeaponComponent.WeaponAttributes;
            return (weaponAttr.Damage * weaponAttr.AttackSpeed) * (1 * (1 + (TotalPrimaryAttribute() / 100)));
        }

        /// <summary>
        /// Different heroes can use different equipment, this helperfunction makes it easier to register.
        /// </summary>
        /// <param name="equipment">The equiment the hero can use as a string array</param>
        protected void RegisterUsableEquipment(string[] equipment)
        {
            usableEquipment = new HashSet<string>(equipment);
        }

        /// <summary>
        /// Adds together all the armor equipped together
        /// </summary>
        /// <returns>the attributes of all the armor</returns>
        protected PrimaryAttributes EquippedItemsAttr()
        {
            PrimaryAttributes armorAttr = new PrimaryAttributes(0, 0, 0);
            foreach (var armor in Equipment)
            {
                //This wouldn't be necessary if weapon could be seperated from armor, but as far as I understand the requirement, it has to be.
                try
                {
                    armorAttr += ((Armor)armor.Value).ArmorComponent.Attributes;
                }
                catch (Exception)
                {
                    continue;
                }
                
            }

            return armorAttr;
        }

        /// <summary>
        /// Equips an item, throws invalid exception if item isn't usable by hero
        /// </summary>
        /// <param name="item">item to be equipped</param>
        /// <returns>success message if succeeded</returns>
		public string Equip(IItem item)
        {
            //Check if item is equipable. The item knows whether it needs to throw invalid weapon or armor exception
            if (!usableEquipment.Contains(item.GetItemTypeAsString()) || item.ItemComponent.ItemLevel > Level) throw item.ItemException();

            //Item is equipable
            Equipment[item.ItemComponent.ItemSlot] = item;

            return item.EquipMessage();
        }

        /// <summary>
        /// Overrides tostring to build a character sheet
        /// </summary>
        /// <returns>a string containing the character sheet</returns>
        public override string ToString()
        {
            StringBuilder bob = new StringBuilder();
            bob.Append($"Name: {Name} \n");
            bob.Append($"Level: {Level} \n");
            bob.Append($"Strength: {TotalAttributes().Strength} \n");
            bob.Append($"Dexterity: {TotalAttributes().Dexterity} \n");
            bob.Append($"Intelligence: {TotalAttributes().Intelligence} \n");
            bob.Append($"Damage: {Damage()}");
            return bob.ToString();
        }
    }
}

