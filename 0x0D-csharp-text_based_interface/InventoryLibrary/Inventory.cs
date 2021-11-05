namespace InventoryLibrary
{
    /// <summary>
    /// This class represents an inventory.
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// from User id
        /// </summary>
        public int user_id { get; set; } = 0;
        /// <summary>
        /// from Item id
        /// </summary>
        public int item_id { get; set; } = 0;
        /// <summary>
        /// number of items; cannot be less than 0; default value = 1
        /// </summary>
        public int quantity { get; set; } = 1;
    }
}