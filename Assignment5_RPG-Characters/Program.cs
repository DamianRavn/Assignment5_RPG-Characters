using System;

namespace Assignment5__RPG_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage Gandalf = new Mage("Gandalf the White");
            Gandalf.LevelUp();
            Gandalf.LevelUp();
            Gandalf.Equip(new Weapon("White Staff", 2, WeaponType.STAFF, 14, 1.0f));
            Gandalf.Equip(new Armor("White Robes", 2, ItemSlot.BODY, ArmorType.CLOTH, new PrimaryAttributes(0, 0, 7)));

            Console.WriteLine(Gandalf.ToString());
        }
    }
}
