using System;

namespace OO_Tasks_Inheritence {
    public abstract class Shape {
        private string _name;
        private string _colour;

        protected Shape(string name, string colour)
        {
            _name = name;
            _colour = colour;
        }
    }

    public abstract class Quadrilateral: Shape{

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }

        public Quadrilateral(string _name, string _colour, double side1, double side2, double side3, double side4): base(_name, _colour)
        {

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }
    }

    public class Square:Quadrilateral{
        public Square(string _colour, string _name, double side1) : base(_colour, _name, side1, side1, side1, side1)
        {

        }
        public virtual double GetPerimeter()
        {
            double Perimeter = (4 * Side1);
            return Perimeter;
        }

        public virtual double GetArea()
        {
            double AreaSquare = Math.Round((Side1 * Side1),2);
            return AreaSquare;
        }

    }

    public class Rectangle : Quadrilateral {

        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(string _name, string _colour, double _side1, double _side2) : base( _name, _colour, _side1, _side2, _side1, _side2)
        {
            Side1 = _side1;
            Side2 = _side2;
        }

        public virtual double GetPerimeter()
        {

            double Perimeter = 2*(Side1 + Side2);
            return Perimeter;
        }

        public virtual double GetArea()
        {
            double GetArea =Math.Round((Side1 * Side2), 2);
            return GetArea;
        }
    }

    public class Circle:Shape {


        //public double PI = Math.PI;
        public double PI = 3.142;
        public double Radius { get; set; }

        public Circle(string _colour, string _name, double radius): base(_colour,_name)
        {
            Radius = radius;
        }

        public double GetPerimeter()
        {
            double Perimeter = Math.Round((2 * PI * Radius), 2);
            return Perimeter;
        }

        public virtual double GetArea()
        {

            double GetArea = Math.Round((PI * (Radius * Radius)), 2);
            return GetArea;
        }

        public virtual double GetCircumference()
        {
            return GetPerimeter();
        }
    }
    
    
}