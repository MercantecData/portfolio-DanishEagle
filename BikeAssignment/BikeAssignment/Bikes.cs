using System;
using System.Collections.Generic;
using System.Text;

namespace BikeAssignment
{
    class Bikes
    {
        public string brand;
        public int wheelsize;
        public string color; 

        public Bikes(string brand, int wheelsize, string color)
        {
            this.brand = brand;
            this.wheelsize = wheelsize;
            this.color = color;
        }
    }
}
