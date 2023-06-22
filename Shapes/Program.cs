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
        class Square : Rectangle
        {
            public override string Name => "Square " + name;

            protected float side;

            public Square(string name, float side) : base(name, side, side) { }
        }
        class Circle : Shape
        {
            public override string Name => "Circle " + name;
            public override float Area => (float)Math.PI * radius * radius;
            public override float Perimeter => (float)Math.PI * 2 * radius;

            protected float radius;

            public Circle(string name, float radius) : base(name)
            {
                this.radius = radius;
            }
        }
        static void Main(string[] args)
        {
            // Declare all shapes
            List<Shape> shapes = new List<Shape> {
                new Rectangle("1", 2, 8),
                new Rectangle("2", 3, 3),
                new Square("3", 5),
                new Circle("4", 1)
            };

            // Print the details of each shape
            foreach(Shape shape in shapes)
            {
                shape.Print();
            }
        }
    }
}
