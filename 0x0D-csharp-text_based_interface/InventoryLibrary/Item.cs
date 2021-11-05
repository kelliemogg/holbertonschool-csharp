using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// An item in the game.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// The name of the item
        /// </summary>
        public string name { get; set; } = "Item Name";
        /// <summary>
        /// The description of the item
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// the price of the item, float, limit to 2 decimal points
        /// </summary>
        public float price { get; set; }
        /// <summary>
        /// a list of strings
        /// </summary>
        public List<string> tags { get; set; }
    }
}