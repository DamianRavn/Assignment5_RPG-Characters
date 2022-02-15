using System;

namespace Assignment5__RPG_Characters
{
	public abstract class BaseHero
	{
		private string name;
		private int level;
		private PrimaryAttributes baseAttributes;
		private PrimaryAttributes totalAttributes;

		public BaseHero()
		{
		}

        public BaseHero(string name)
        {
            this.name = name;
			this.level = 1;

        }
    }
}

