namespace Scripts.Lab1.CreatingProperties
{
    public class Player
    {
        private int experience;

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        public int Level
        {
            get
            {
                return experience / 1000;
            }
            set
            {
                experience = value * 1000;
            }
        }

        public int Health { get; set; }
    }
}