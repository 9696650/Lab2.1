using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ShapeLibrary
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


        public double GetSideLength()
        {

            return Math.Sqrt(sideX * sideX + sideY * sideY);
        }
    }
        public class Rhombus : Figure
        {
            private double height; 

           
            public Rhombus() : base()
            {
                height = 0;
            }

          
            public Rhombus(double x, double y, double h) : base(x, y)
            {
                height = h;
            }

            
            public double Height => height;

           
            public double GetPerimeter()
            {
                
                return 4 * GetSideLength();
            }

           
            public double GetArea()
            {
                double side = GetSideLength();
                return side * height;
            }

            
            public string GetInfo()
            {
                return $"Rhombus Info: Side = {GetSideLength():F2}, Height = {height:F2}";
            }
        }
    }
