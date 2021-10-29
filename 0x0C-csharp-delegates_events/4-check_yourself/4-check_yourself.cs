﻿using System;

/// <summary>
/// create an enum called Modifier with the values Weak, Base, Strong
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak modifier
    /// </summary>
    Weak,
    /// <summary>
    /// Base modifier
    /// </summary>
    Base,
    /// <summary>
    /// Strong modifier
    /// </summary>
    Strong
}

/// <summary>
/// delegate called CalculateModifier that takes a float amount
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary>
/// Public class called Player
/// </summary>
public class Player
{
    /// <summary>
    /// property string called name
    /// </summary>
    private string name { get; set; }
    /// <summary>
    /// property float called maxHp
    /// </summary>
    private float maxHp { get; set; }
    /// <summary>
    /// property float called hp
    /// </summary>
    public float hp { get; set; }
    /// <summary>
    /// Constructor for Player
    /// </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        EventHandler<CurrentHPArgs> HPCheck = CheckStatus;
        this.name = name;
        status = $"{this.name} is ready to go!";
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
    /// delegate called CalculateHealth that takes a float amount
    /// </summary>
    public delegate void CalculateHealth(float amount);
    /// <summary>
    /// event called TakeDamage
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{name} takes 0 damage!");
        }
        else
        {
            hp -= damage;
            ValidateHP(hp);
            Console.WriteLine($"{name} takes {damage} damage!");
        }
    }
    /// <summary>
    /// method called HealDamage
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{name} heals 0 HP!");
        }
        else
        {
            hp += heal;
            ValidateHP(hp);
            Console.WriteLine($"{name} heals {heal} HP!");
        }
    }
    /// <summary>
    /// method called ValidateHP that sets the new value of the player's hp
    /// </summary>
    public void ValidateHP(float newHp)
    {
        HPCheck(this, new CurrentHPArgs(hp));
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }
    /// <summary>
    /// method ApplyModifier that follows the prototype of CalculateModifier
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        switch (modifier)
        {
            case Modifier.Weak:
                return baseValue * 0.5f;
            case Modifier.Base:
                return baseValue;
            case Modifier.Strong:
                return baseValue * 1.5f;
            default:
                return baseValue;
        }
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
    /// <summary>
    /// EventHandler called HPCheck of type CurrentHPArgs
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// new private property status of type string
    /// </summary>
    private string status { get; set; }

    /// <summary>
    /// method called CheckStatus
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            Console.WriteLine($"{name} is in perfect health!");
        }
        else if (e.currentHp >= maxHp * 0.5f && e.currentHp < maxHp)
        {
            Console.WriteLine($"{name} is doing well!");
        }
        else if (e.currentHp >= maxHp * 0.25f && e.currentHp < maxHp * 0.5f)
        {
            Console.WriteLine($"{name} isn't doing too great...");
        }
        else if (e.currentHp > 0 && e.currentHp < maxHp * 0.25f)
        {
            Console.WriteLine($"{name} needs help!");
        }
        else if (e.currentHp <= 0)
        {
            Console.WriteLine($"{name} is knocked out!");
        }
    }

}

/// <summary>
/// class called CurrentHPArgs that inherits from EventArgs with a property called currentHp, a constructor that takes float newHp and sets it as currentHp's value
/// </summary>
public class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}
