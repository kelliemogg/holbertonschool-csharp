using System;

/// <summary>
/// Public class called Player
/// </summary>
public class Player
{
    /// <summary>
    /// property string called name
    /// </summary>
    public string name { get; set; }
    /// <summary>
    /// property float called maxHp
    /// </summary>
    public float maxHp { get; set; }
    /// <summary>
    /// property float called hp
    /// </summary>
    public float hp { get; set; }
    /// <summary>
    /// Constructor for Player
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp < 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.hp = this.maxHp;
    }
    /// <summary>
    /// Method called PrintHealth()
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    /// <summary>
    /// Public delegate called HealthChanged
    /// </summary>
    public delegate void HealthChanged(int health);

    /// <summary>
    /// Public event called HealthChanged
    /// </summary>
    public event HealthChanged HealthChangedEvent;

    /// <summary>
    /// Public method called OnHealthChanged
    /// </summary>
    public void OnHealthChanged(int health)
    {
        if (HealthChangedEvent != null)
        {
            HealthChangedEvent(health);
        }
    }
}
