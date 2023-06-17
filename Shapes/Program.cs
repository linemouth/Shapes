using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare all shapes
            float width1 = 2;
            float height1 = 8;

            float width2 = 3;
            float height2 = 3;

            // Print the details of each shape
            Console.WriteLine("Shape 1");
            Console.WriteLine($"    Area: {width1 * height1}");
            Console.WriteLine($"    Perimeter: {2 * width1 + 2 * height1}");

            Console.WriteLine("Shape 2");
            Console.WriteLine($"    Area: {height2 * width2}");
            Console.WriteLine($"    Perimeter: {2 * height2 + 2 * width2}");
        }
    }
}
