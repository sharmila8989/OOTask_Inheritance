using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTask_Inheritance
{
    public abstract class Shape
    {
        // private fields
        private string _colour;
        private string _name;
        // colour property
        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
        // name propert
        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }
        //constructor
        public Shape(string pColour, string pName)
        {
            _colour = pColour;
            _name = pName;
        }
        // abstract methods implemented in derived classes
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}
