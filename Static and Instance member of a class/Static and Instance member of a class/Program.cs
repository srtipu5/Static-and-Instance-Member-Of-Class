using System;

namespace Static_and_Instance_member_of_a_class
{
    public class Circle
    {
        // by default class modifier are private
        public int radius; // instance field
        static float PI; //static field
        static Circle() /*static constructor implicitly called before instance constructor and must be parameterless */
        {
            Circle.PI = 3.1416F;
        }
        public Circle(int radius) //instance constructor
        {
            this.radius = radius;
        }
        public void AreaOfCircle() //instance method
        {
            Console.WriteLine("Area Of a Circle : {0}",Math.Round(PI * radius * radius,3));
        }
        public static void ValueOfPI() //static method
        {
            Console.WriteLine("PI : {0}",PI);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(2);
            c.AreaOfCircle();   //instance fields or method called using class object name
            Circle.ValueOfPI(); //static fields or method called using class name
            Console.ReadKey();
        }
    }
}
