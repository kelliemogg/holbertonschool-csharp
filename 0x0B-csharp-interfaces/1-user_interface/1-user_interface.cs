using System;

/// <summary>
/// abstract class Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// declare public string name
    /// </summary>
    string name { get; set; }
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
/// class Test Object
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// property durability
    /// </summary>
    public int durability { get; set; }
    /// <summary>
    /// property isCollected
    /// </summary>
    public bool isCollected { get; set; }
    /// <summary>
    /// property name
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// overriding ToString
    /// </summary>
    public override string ToString()
    {
        return name + " is a " + GetType().Name;
    }
    /// <summary>
    /// override public void Interact()
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("Interaction with " + this.name);
    }
    /// <summary>
    /// override public void Break()
    /// </summary>
    public void Break()
    {
        {
            Console.WriteLine("Break " + this.name);
        }
    }
    /// <summary>
    /// override public void Collect()
    /// </summary>
    public void Collect()
    {
        {
            Console.WriteLine("Collect " + this.name);
            isCollected = true;
        }
    }
}
