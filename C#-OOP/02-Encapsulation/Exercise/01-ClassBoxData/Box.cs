using System;
using System.Collections.Generic;
using System.Text;

namespace Exer0j1.ClassBoxData
{
    public class Box
    {        
        private const string ERROR = "{0} cannot be zero or negative.";
        private const int ZERO = 0;

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }   

        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                ValidateSide(value, nameof(this.Length));
                this.length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            private set
            {
                ValidateSide(value, nameof(this.Width));
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                ValidateSide(value, nameof(this.Height));
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = (2 * this.Length * this.Width)
                               + (2 * this.Length * this.Height)
                               + (2 * this.Width * this.Height);
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = (2 * this.Length * this.Height)
                + (2 * this.Width * this.Height);
            return lateralSurfaceArea;
        }
        public double Volume()
        {
            double volume = this.Length * this.Width * this.Height;
            return volume;
        }
        private void ValidateSide(double value, string sideName)
        {
            if (value <= ZERO)
            {
                throw new ArgumentException(String.Format(ERROR, sideName));
            }
        }
    }
}
