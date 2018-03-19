using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTask_Inheritance
{
    class Quadrilateral: Shape
    {
        private const int _numSides = 4;
        public int NumSides
        {
            get { return _numSides; }
        }
        public Quadrilateral(string pColour, string pName) : base(pColour, pName) { }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
