using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{ 
  public class circle
        {
            double radius;
            double Pi = 3.14159;
            public circle(double r)
            {
                this.radius = r;
            }
            public double getArea()
            {
                return Pi * radius * radius;
            }
            public double getCircum()
            {
                return 2 * Pi * radius;
            }
            public double getDiameter()
            {
                return radius * 2;
            }
            public static void Main(String[] args)
            {
                Console.WriteLine("Enter the radius:");
                double rr = Convert.ToInt32(Console.ReadLine());
                circle circle = new circle(rr);
                Console.WriteLine("Radius" + rr);
                Console.WriteLine(".\nArea" + circle.getArea());
                Console.WriteLine(".\nCircumference" + circle.getCircum());
                Console.WriteLine(".\nDiameter" + circle.getDiameter());
            }
        }

    }
