using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTask_Inheritance
{
    class Square:Quadrilateral
    {
        private double _sideLength;
        public double SideLength
        {
            get { return _sideLength;}
            set { _sideLength = value; }
        }
        public Square(string pColour, string pName, double pSideLength):base(pColour, pName)
        {
            _sideLength = pSideLength;
        }
        public override double GetArea()
        {
            return Math.Round((_sideLength * _sideLength),2);
        }
        public override double GetPerimeter()
        {
            return Math.Round((4 * _sideLength),2);
        }
    }
}
