using System;

namespace Shapes
{
    internal class Program
    {
        class Shape
        {
            public string name;
            public float width;
            public float height;
        }
        static void Main(string[] args)
        {
            // Declare all shapes
            Shape shape1 = new Shape();
            shape1.name = "Shape 1";
            shape1.width = 2;
            shape1.height = 8;

            Shape shape2 = new Shape();
            shape2.name = "Shape 2";
            shape2.width = 3;
            shape2.height = 3;

            // Print the details of each shape
            PrintShape(shape1);
            PrintShape(shape2);
        }
        static void PrintShape(Shape shape)
        {
            Console.WriteLine(shape.name);
            Console.WriteLine($"    Area: {shape.width * shape.height}");
            Console.WriteLine($"    Perimeter: {2 * shape.width + 2 * shape.height}");
        }
    }
}
