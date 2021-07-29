using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject2;

        try
        {
            newObject2 = new Enemies.Zombie(1000);
            Console.WriteLine("{0} is of type {1} and has a total of {2} health", newObject2.Name, newObject2.GetType(), newObject2.GetHealth());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
