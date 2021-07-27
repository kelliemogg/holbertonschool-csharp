using System;

namespace Enemies
{
    /// <summary>
    /// Defines class Zombie 
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Creates private field health
        /// </summary>
        private int health;
        /// <summary>
        /// Creates private field name
        /// </summary>
        private string name = "(No name)";
        /// <summary>
        /// Creates public Zombie obj
        /// </summary>
        public Zombie()
        {
            this.health = 0;
            this.name = "(No name)";
        }
        /// <summary>
        /// instance of Zombie with params passed
        /// </summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
        }
        /// <summary>
        /// Gets Health of Zombie object
        /// </summary>

        /// <summary>
        /// gets and sets values for Name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// returns the Health for a zombie
        /// </summary>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// Overrides ToString to print ideal output about objs
        /// </summary>
        public override string ToString()
        {
            return "Zombie Name: " + name + " / Total Health: " + health;
        }
    }
}
