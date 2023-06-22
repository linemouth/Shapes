using System;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare all shapes
            (string name, float width, float height) shape1 = ("Shape 1", 2, 8);
            (string name, float width, float height) shape2 = ("Shape 2", 3, 3);

            // Print the details of each shape
            PrintShape(shape1);
            PrintShape(shape2);
        }
        static void PrintShape((string name, float width, float height) shape)
        {
            Console.WriteLine(shape.name);
            Console.WriteLine($"    Area: {shape.width * shape.height}");
            Console.WriteLine($"    Perimeter: {2 * shape.width + 2 * shape.height}");
        }
    }
}
