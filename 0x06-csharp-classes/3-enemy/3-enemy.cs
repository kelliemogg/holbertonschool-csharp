using System;

namespace Enemies
{
    /// <summary>
    /// Defines class Zombie 
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Creates public field health
        /// </summary>
        private int health;
        /// <summary>
        /// Initialize new instance
        /// </summary>
        public Zombie()
        {
            this.health = 0;
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
        public int GetHealth()
        {
            return health;
        }
    }
}
