using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public abstract class Figure
    {
        public double width, height, radius;
        public const float pi = 3.14f;
        
        //class which contains abstract method - then it becomes ac=bstract class - declaration
        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double width, double height)
        {
            //this.width - parent class width
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

    }

    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return radius * radius*pi;
        }
    }

    public class Cone : Figure
    {
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;   
        }

        public override double GetArea()
        {
            return (pi * radius*(Math.Sqrt(height*height+radius*radius)));
        }
    }

    class TestFigure 
    {
        public static void Main()
        {
            Rectangle rectangle = new Rectangle(10,20);
            Circle circle = new Circle(10);
            Cone cone = new Cone(10,20);

            Console.WriteLine("Area of rectangle = "+rectangle.GetArea());
            Console.WriteLine("Area of Circle = "+circle.GetArea());
            Console.WriteLine("Area of Cone = "+cone.GetArea());

        }
    }


}
