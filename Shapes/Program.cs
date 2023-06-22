using System;
using System.Collections.Generic;

namespace Shapes
{
    internal class Program
    {
        abstract class Shape
        {
            public abstract string Name { get; }
            public abstract float Area { get; }
            public abstract float Perimeter { get; }

            protected string name;

            public Shape(string name)
            {
                this.name = name;
            }

            public void Print()
            {
                Console.WriteLine(Name);
                Console.WriteLine($"    Area: {Area}");
                Console.WriteLine($"    Perimeter: {Perimeter}");
            }
        }
        class Rectangle : Shape
        {
            public override string Name => "Rectangle " + name;
            public override float Area => width * height;
            public override float Perimeter => 2 * width + 2 * height;

            protected float width;
            protected float height;

            public Rectangle(string name, float width, float height) : base(name)
            {
                this.width = width;
                this.height = height;
            }
        }
        static void Main(string[] args)
        {
            // Declare all shapes
            List<Shape> shapes = new List<Shape> {
                new Rectangle("1", 2, 8),
                new Rectangle("2", 3, 3)
            };

            // Print the details of each shape
            foreach(Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}
