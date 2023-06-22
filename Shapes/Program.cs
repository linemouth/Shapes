using System;
using System.Collections.Generic;

namespace Shapes
{
    internal class Program
    {
        class Shape
        {
            public float Area => width * height;
            public float Perimeter => 2 * width + 2 * height;
            public string name;
            public float width;
            public float height;

            public Shape(string name, float width, float height)
            {
                this.name = name;
                this.width = width;
                this.height = height;
            }
            public void Print()
            {
                Console.WriteLine(name);
                Console.WriteLine($"    Area: {Area}");
                Console.WriteLine($"    Perimeter: {Perimeter}");
            }
        }
        static void Main(string[] args)
        {
            // Declare all shapes
            List<Shape> shapes = new List<Shape> {
                new Shape("Shape 1", 2, 8),
                new Shape("Shape 2", 3, 3)
            };

            // Print the details of each shape
            foreach(Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}
