using System;

namespace OO_Tasks_Interface {
    public interface IShapeProps { }

    public interface ICircleProps { }

    public class Shape {
        private string _name;
        private string _colour;
    }

    public class Quadrilateral : Shape {
        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }

    public class Square:Quadrilateral {
      
        public string _name { get; set; }
        public string _colour { get; set; }
        public double _side1 { get; set; }

        public Square(string name, string colour, double side1)
        {
            _name = name;
            _colour = colour;
            _side1 = side1;
        }

        public virtual double GetPerimeter()
        {
            double Perimeter = (4 * _side1);
            return Perimeter;
        }

        public virtual double GetArea()
        {
            double AreaSquare = Math.Round((_side1 * _side1), 2);
            return AreaSquare;
        }
    }

    public class Rectangle:Quadrilateral {

       public string _name { get; set; }
        public string _colour { get; set; }
        public double _length { get; set; }
        public double _width { get; set; }

        public Rectangle(string name, string colour, double length, double width)
        {
            _name = name;
            _colour = colour;
            _length = length;
            _width = width;
        }

        public virtual double GetPerimeter()
        {

            double Perimeter = 2 * (_length + _width);
            return Perimeter;
        }

        public virtual double GetArea()
        {
            double GetArea = Math.Round((_length * _width), 2);
            return GetArea;
        }
    }

    public class Circle:Shape {

        public string _name { get; set; }
        public string _colour { get; set; }
        public double _radius { get; set; }

        public double PI = 3.142;
        public Circle(string _name, string _colour, double _radius) 
        {
            this._radius = _radius;

        }

        public double GetPerimeter()
        {
            double Perimeter = Math.Round((2 * PI * _radius), 2);
            return Perimeter;
        }

        public virtual double GetArea()
        {

            double GetArea = Math.Round((PI * (_radius * _radius)), 2);
            return GetArea;
        }

        public virtual double GetCircumference()
        {
            return GetPerimeter();
        }
    }
}