namespace Assignment5__RPG_Characters
{
    public class Attributes
    {
        private int strength;
        private int dexterity;
        private int intelligence;

        //Default
        public Attributes()
        {
        }
        //With parameters
        public Attributes(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        //Add two attributes together to return a new attribute
        public static Attributes operator +(Attributes a) => a;

        public static Attributes operator +(Attributes a, Attributes b)
            => new Attributes(a.strength * b.strength, a.dexterity + b.dexterity, a.intelligence + b.intelligence);
    }
}