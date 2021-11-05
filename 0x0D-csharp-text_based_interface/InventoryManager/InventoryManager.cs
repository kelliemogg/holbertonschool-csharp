using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class InventoryManager
{
    public Dictionary<string, BaseClass> objects;
    public List<string> classes = new List<string> {
    "BaseClass",
    "Item",
    "Inventory"
    };
    /// <summary>
    /// On start, load all objects from JSONStorage.
    /// </summary>
    public void Start()
    {
        JSONStorage Store = new JSONStorage();
        /// <summary> 
        /// load all objects from JSONStorage
        /// </summary>
        try {
            objects = Store.LoadAll<BaseClass>();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        initial_prompt();
    }
    static void Main(string[] args)
    {
        while (true)
            ReadInput();
    }
    /// <summary>
    /// Initial prompt for user.
    /// </summary>
    public void initial_prompt()
    {
        Console.WriteLine("Welcome to the inventory manager!");
        Console.WriteLine("-------------------------");
        Console.WriteLine("<ClassNames> show all ClassNames of objects");
        Console.WriteLine("<All> show all objects");
        Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
        Console.WriteLine("<Create [ClassName]> a new object");
        Console.WriteLine("<Show [ClassName object_id]> an object");
        Console.WriteLine("<Show [ClassName object_id]> an object");
        Console.WriteLine("<Update [ClassName object_id]> an object");
        Console.WriteLine("<Delete [ClassName object_id]> an object");
        Console.WriteLine("<Exit>");
        Console.WriteLine("-------------------------");
    }
    /// <summary>
    /// Take user input from the command line using the Console namespace
    /// </summary>
    public void ReadInput()
    {
        /// <summary>
        /// Take user input from the command line using the Console namespace - to lowercase
        /// </summary>

        string input = Console.ReadLine().ToLower();
        string[] input_split = input.Split(' ');
        string command = input_split[0];
        if (command == "ClassNames") {
            Console.WriteLine("ClassNames:");
            foreach (string key in objects.Keys) {
                Console.WriteLine(key);
            }
            initial_prompt();
        }
        else if (command == "All") {
            if (input_split.Length == 1) {
                Console.WriteLine("All:");
                foreach (BaseClass obj in objects.Values) {
                    Console.WriteLine(obj);
                }
                initial_prompt();
            }
            else {
                string class_name = input_split[1];
                Console.WriteLine("All " + class_name + ":");
                foreach (BaseClass obj in objects.Values) {
                    if (obj.GetType().Name == class_name) {
                        Console.WriteLine(obj);
                    }
                    else
                        Console.WriteLine("<class_name> is not a valid object type");
                }
                initial_prompt();
            }
        }
        else if (command == "Create") {
            string class_name = input_split[1];
            BaseClass obj = null;
            /// <summary>
            /// Create a new object based on the class_name
            /// </summary>
            try {
                obj = Activator.CreateInstance(Type.GetType(class_name)) as BaseClass;
                initial_prompt();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        else if (command == "Show") {
            string class_name = input_split[1];
            int object_id = int.Parse(input_split[2]);
            BaseClass obj = null;
            /// <summary>
            /// Find the object based on the class_name and object_id
            /// </summary>
            try {
                obj = objects[class_name + "_" + object_id];
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            /// <summary>
            /// Print the object
            /// </summary>
            if (obj != null) {
                Console.WriteLine(obj);
                initial_prompt();
            }
        }
        else if (command == "Update") {
            string class_name = input_split[1];
            int object_id = int.Parse(input_split[2]);
            BaseClass obj = null;
            /// <summary>
            /// Find the object based on the class_name and object_id
            /// </summary>
            try {
                obj = objects[class_name + "_" + object_id];
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            /// <summary>
            /// Update the object
            /// </summary>
            if (obj != null) {
                Console.WriteLine("Update " + obj);
                initial_prompt();
            }
            else if (classes.Contains(class_name) == false) {
                Console.WriteLine("<class_name> is not a valid object type");
            }
        }
        else if (command == "Delete") {
            string class_name = input_split[1];
            int object_id = int.Parse(input_split[2]);
            BaseClass obj = null;
            /// <summary>
            /// Find the object based on the class_name and object_id
            /// </summary>
            try {
                obj = objects[class_name + "_" + object_id];
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            /// <summary>
            /// Delete the object
            /// </summary>
            if (obj != null) {
                objects.Remove(class_name + "_" + object_id);
                initial_prompt();
            }
        }
        /// <summary>
        /// Quit the application
        /// </summary>
        else if (command == "Exit") {
            Environment.Exit(0);
        }
        else {
            Console.WriteLine("Unknown command");
        }

    }
}