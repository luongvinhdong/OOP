using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Fundamental.Models
{
    public class Brick
    {
        public string Name { get; private set; }
        public double Length { get; private set; }
        public double Height { get; private set; }
        public double Width { get; private set; }

        private double _surfaceArea 
        {
            get
            {
                return 2 * this.Length * this.Height +
                       2 * this.Length * this.Width +
                       2 * this.Height * this.Width;
            }
        }

        public Brick(string name, double length, double height, double width)
        {
            this.Name = name;
            this.Length = length;
            this.Height = height;
            this.Width = width;
        }

        public double GetArea(double length, double height, double width)
        {
            return _surfaceArea;
        }
    }
}
