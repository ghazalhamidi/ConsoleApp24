using System;

namespace ConsoleApp24
{
    class circle
    {
        private double radius;
        public circle(double radius)
        {
            this.radius = radius;
        }
        public double masahat()
        {
            return Math.PI * radius * radius;
        }
        public double mohit()
        {
            return 2 * Math.PI * radius;
        }
    }
    class program
    {
        static void Main()
        {
            double radius;
            radius = Convert.ToDouble(Console.ReadLine());
            circle c = new circle(radius);
            Console.WriteLine("radius:" + radius);
            Console.WriteLine("masahat:" + c.masahat());

            Console.WriteLine("circumference:" + c.mohit());
        }
    }
}
