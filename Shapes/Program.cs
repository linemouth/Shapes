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

            public Shape(string name, float width, float height)
            {
                this.name = name;
                this.width = width;
                this.height = height;
            }
        }
        static void Main(string[] args)
        {
            // Declare all shapes
            Shape shape1 = new Shape("Shape 1", 2, 8);
            Shape shape2 = new Shape("Shape 2", 3, 3);

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
