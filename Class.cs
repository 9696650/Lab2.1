using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
    public class Figure
    {

        private double sideX;
        private double sideY;


        public Figure()
        {
            sideX = 0;
            sideY = 0;
        }


        public Figure(double x, double y)
        {
            sideX = x;
            sideY = y;
        }


        public double SideX => sideX;
        public double SideY => sideY;


        public double SideLength()
        {

            return Math.Sqrt(sideX * sideX + sideY * sideY);
        }
    }
    public class Rhomb : Figure
    {
        private double height;


        public Rhomb() : base()
        {
            height = 0;
        }


        public Rhomb(double x, double y, double h) : base(x, y)
        {
            height = h;
        }


        public double Height => height;


        public double GetPerimeter()
        {

            return 4 * SideLength();
        }


        public double GetArea()
        {
            double side = SideLength();
            return side * height;
        }


        public string GetInfo()
        {
            return $"Info: Side = {SideLength():F2}, Height = {height:F2}";
        }
    }
}
