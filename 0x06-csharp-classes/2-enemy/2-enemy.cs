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
        public int health;
        /// <summary>
        /// Initialize new instance
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
        public Zombie(int value)
        {
            /// <summary>
            /// Constructor that takes parameters
            /// Add conditional for values
            /// </summary>
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
                this.health = value;
        }
    }
}