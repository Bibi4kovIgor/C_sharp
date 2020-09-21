using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleWork
{
    public class Circle
    {

        private double X { get; set; } = 0;

        private double Y { get; set; } = 0;

        private double r;
        public double R
        {
            get { return r; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Radius must be > 0");
                else r = value;
            }
        }

        public Circle() {
            Init(0.0, 0.0, 1.0);
        }

        public Circle(double x, double y, double r)
        {
            Init(x, y, r);
        }

        public Circle(Circle circle)
        {
            Init(circle.X, circle.Y, circle.R);
        }

        private void Init(double x, double y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public bool IsCiclesConcentric(Circle circle)
        {
            if (X == circle.X && Y == circle.Y) return true;
            else return false;
        }

        public bool IsCircleEquals(Circle circle)
        {
            if (R == circle.R) return true;
            else return false;
        }

        public bool IsCirclesIntersect(Circle circle)
        {
            double dx = circle.X - X;
            double dy = circle.Y - Y;
            double dist = Math.Sqrt(dx * dx + dy * dy);

            if (dist > R + circle.R) return false;
            else if (dist < Math.Abs(circle.R - R)) return false;
            else if (dist == 0 && R == circle.R) return false;
            else return true;
        }

        public void Input()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());

            Init(x, y, r);            
        }

        public void Print()
        {
            Console.WriteLine("x = " + X + "\n" + "y = " + Y + "\n" + "r = " + R + "\n");
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public double GetArea()
        {
            return Math.PI * R * R;
        }
        
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(1.1, 1.2, 5.3);
            Console.WriteLine("Insert Circle 1 parameters " + "\n");
            circle1.Input();
            Console.WriteLine("Circle1 parameters are \n");
            circle1.Print();
            Console.WriteLine("Circle2 parameters are \n");
            circle2.Print();
            Console.WriteLine("Circle1 perimeter is " + circle1.GetPerimeter() + "\n");
            Console.WriteLine("Circle2 perimeter is " + circle2.GetPerimeter() + "\n");
            Console.WriteLine("Circle1 area is " + circle1.GetArea() + "\n");
            Console.WriteLine("Circle2 area is " + circle2.GetArea() + "\n");
            Console.WriteLine("is Circle1 and Circle2 concentric " + circle1.IsCiclesConcentric(circle2) + "\n");
            Console.WriteLine("is Circle1 and Circle2 intersects " + circle1.IsCirclesIntersect(circle2) + "\n");
            Console.WriteLine("is Circle1 and Circle2 Equals " + circle1.IsCircleEquals(circle2) + "\n");
            Console.ReadKey();

        }
    }
}
