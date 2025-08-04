﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three sides of a triangle:");

        Console.Write("Side 1: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Side 2: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Side 3: ");
        int side3 = int.Parse(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("The triangle is Equilateral.");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("The triangle is Isosceles.");
        else
            Console.WriteLine("The triangle is Scalene.");
    }
}
