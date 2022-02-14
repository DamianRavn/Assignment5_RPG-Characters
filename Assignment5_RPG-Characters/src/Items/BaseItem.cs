namespace Assignment5__RPG_Characters
{
    public abstract class BaseItem
    {
        public enum ItemSlot { WEAPON, BODY, HEAD, LEGS}

        private string name;
        private int level;
        private ItemSlot itemSlot;

        public BaseItem()
        {
        }

        public BaseItem(string name, int level, ItemSlot itemSlot)
        {
            this.name = name;
            this.level = level;
            this.itemSlot = itemSlot;
        }
    }
}