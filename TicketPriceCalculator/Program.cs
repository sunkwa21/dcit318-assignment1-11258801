﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int price;

        if (age <= 12 || age >= 65)
            price = 7;
        else
            price = 10;

        Console.WriteLine($"Your ticket price is: GHC{price}");
    }
}
