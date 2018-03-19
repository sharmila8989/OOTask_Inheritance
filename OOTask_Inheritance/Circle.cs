using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTask_Inheritance
{
    class Circle:Shape
    {
        public const double PI = 3.142;
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        public Circle(string pColour, string pName, double pRadius):base(pColour, pName)
        {
            _radius = pRadius;
        }
        public override double GetArea()
        {
            return Math.Round((PI * _radius * _radius), 2);
        }
        public override double GetPerimeter()
        {
            return Math.Round((2 * PI * _radius),2);
        }
        public double GetCircumference()
        {
            return Math.Round((2 * PI * _radius), 2);
        }

    }
}
