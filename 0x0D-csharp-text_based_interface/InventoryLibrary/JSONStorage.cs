using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace InventoryLibrary
{
    /// <summary>
    ///     Class for storing and loading JSON data.
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        /// dictionary where keys are <ClassName>.<id> and values are the objects
        /// </summary>
        public Dictionary<string, object> objects { get; set; }= new Dictionary<string, object>();
        /// <summary>
        /// Method that returns objects dictionary called All()
        /// </summary>
        /// <returns>Dictionary of objects</returns>
        public Dictionary<string, object> All()
        {
            return objects;
        }
        /// <summary>
        /// Method that adds a new key-value pair to objects dictionary
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="value">Value</param>
        public void New(string key, object value)
        {
            /// <summary>
            /// key is the class name and id and value is the object
            /// </summary>

            objects.Add(key, value);
        }
        /// <summary>
        /// Method that serializes objects to JSON and saves to the JSON file
        /// </summary>
        public void Save()
        {
            /// <summary>
            /// Serializes objects to JSON
            /// </summary>
            string json = JsonSerializer.Serialize(this.objects);
            /// <summary>
            /// Saves JSON to the JSON file
            /// </summary>
            Directory.CreateDirectory("storage");
            File.WriteAllText("storage/inventory_manager.json", json);
        }
        /// <summary>
        /// Method that loads JSON from the JSON file and deserializes it to objects dictionary
        /// </summary>
        public void Load()
        {
            /// <summary>
            /// Loads JSON from the JSON file
            /// </summary>
            string json = File.ReadAllText("storage/inventory_manager.json");
            /// <summary>
            /// Deserializes JSON to objects dictionary
            /// </summary>
            objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
        }
    }
}
