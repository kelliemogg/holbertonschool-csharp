﻿using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int lastdigit = number % 10;
        if (lastdigit < 0)
            lastdigit = lastdigit * -1;
        Console.Write(lastdigit);
        return (lastdigit);
    }
}
