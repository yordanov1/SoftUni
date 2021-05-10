using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {

        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height 
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.height = value;
            }
        }
        public double Width 
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.width = value;
            }
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 2 + this.Height * 2;
        }

        public override string Draw()
        {
            return base.Draw() + nameof(Rectangle);
        }
    }
}
