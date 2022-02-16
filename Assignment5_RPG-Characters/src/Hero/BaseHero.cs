using System;
using System.Collections.Generic;

namespace Assignment5__RPG_Characters
{
	public abstract class BaseHero
	{
        public string Name { get; set; }
        public int Level { get; set; }
		public PrimaryAttributes BaseAttributes { get; set; }
		public PrimaryAttributes TotalAttributes { get; set; }

        public Dictionary<ItemSlot, IItem> Equipment { get; set; }

        protected HashSet<string> usableEquipment;

        public BaseHero()
		{
            Equipment = new Dictionary<ItemSlot, IItem>();
            //makes calculating the damage easier if the hero has a weapon on creation, so i added the fist weapon.
            var fist = new Weapon("fist", 1, ItemSlot.WEAPON, WeaponType.FISTS, 1, 1);
            Equipment.Add(ItemSlot.WEAPON, fist);
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
        /// <returns>Main attribute</returns>
        protected abstract int GetMainAttribute();

        public float Damage()
        {
            var weapon = (Weapon)Equipment[ItemSlot.WEAPON];
            var weaponAttr = weapon.WeaponComponent.WeaponAttributes; // Equipment[ItemSlot.WEAPON].GetAttributes<WeaponAttributes>();
            return (weaponAttr.Damage * weaponAttr.AttackSpeed) * (1 * (1 + (GetMainAttribute() / 100)));
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
        /// Equips an item, throws invalid exception if item isn't usable by hero
        /// </summary>
        /// <param name="item">item to be equipped</param>
		public void Equip(IItem item)
        {
            //Check if item is equipable. The item knows whether it needs to throw invalid weapon or armor exception, let it deal with it
            if (!usableEquipment.Contains(item.GetItemType()) || item.ItemComponent.ItemLevel > Level) throw item.ItemException();

            //Item is equipable
            Equipment.Add(item.ItemComponent.ItemSlot, item);
        }
    }
}

