using System;
using System.Collections.Generic;

/// <summary>
/// abstract class Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// declare public string name
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// overriding ToString
    /// </summary>
    public override string ToString()
    {
        return name + " is a " + GetType().Name;
    }
}

/// <summary>
/// Interface Interactive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// declare public void Interact()
    /// </summary>
    void Interact();
}
/// <summary>
/// Interface Breakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// declare property durability
    /// </summary>
    int durability { get; set; }
    /// <summary>
    /// declare public void Break()
    /// </summary>
    void Break();
}
/// <summary>
/// Interface Collectable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// property isCollected
    /// </summary>
    bool isCollected { get; set; }
    /// <summary>
    /// declare public void Collect()
    /// </summary>
    void Collect();
}
/// <summary>
/// class Door
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// constructor
    /// </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// override Interact
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the " + this.name + ". It's locked.");
    }
}

/// <summary>
/// class Decoration : Base, IInteractive, IBreakable
/// </summary>

public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// public bool
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// constructor
    /// </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
    /// <summary>
    /// property durability
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// override Interact
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine("The " + this.name + " has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine("You look at the " + this.name + ". There's a key inside.");
        }
        else
        {
            Console.WriteLine("You look at the " + this.name + ". Not much to see here.");
        }
    }
    /// <summary>
    /// override Break
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine("You hit the " + this.name + ". It cracks.");
        }
        else if (durability == 0)
        {
            Console.WriteLine("You smash the " + this.name + ". What a mess.");
        }
        else
        {
            Console.WriteLine("The " + this.name + " is already broken.");
        }
    }
}

/// <summary>
/// class Key : Base, ICollectable
/// </summary>

public class Key : Base, ICollectable
{
    /// <summary>
    /// property isCollected
    /// </summary>
    public bool isCollected { get; set; }
    /// <summary>
    /// constructor
    /// </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }
    /// <summary>
    /// override Collect
    /// </summary>
    public void Collect()
    {
        if (isCollected)
        {
            Console.WriteLine("You have already picked up the " + this.name + ".");
        }
        else
        {
            isCollected = true;
            Console.WriteLine("You pick up the " + this.name + ".");
        }
    }
}
/// <summary>
/// class RoomObjects
/// </summary>

public class RoomObjects
{
    /// <summary>
    /// take a list of objects, iterate through it, and execute methods depending on what interface that item implements
    /// </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (item is IInteractive && type == typeof(IInteractive))
            {
                IInteractive interactive = (IInteractive)item;
                interactive.Interact();
            }
            else if (item is IBreakable && type == typeof(IBreakable))
            {
                IBreakable breakable = (IBreakable)item;
                breakable.Break();
            }
            else if (item is ICollectable && type == typeof(ICollectable))
            {
                ICollectable collectable = (ICollectable)item;
                collectable.Collect();
            }
        }
    }
}
