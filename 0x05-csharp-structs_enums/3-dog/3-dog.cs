﻿using System;

enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    public override string ToString()
    {
        if (name == null)
            name = "";
        if (age == null)
            age = 0;
        if (owner == null)
            owner = "";
        return "Dog Name: " + name.ToString() + '\n'
        + "Age: " + age.ToString() + '\n'
        + "Owner: " + owner.ToString() + '\n'
        + "Rating: " + rating.ToString();
    }
}
