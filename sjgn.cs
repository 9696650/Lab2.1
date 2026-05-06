using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._4
{
   
  
       

        class Program
        {
            static void Main()
            {


                Rhombus myRhombus = new Rhombus(8, 9, 5);


                Console.WriteLine(myRhombus.GetInfo());


                double perimeter = myRhombus.GetPerimeter();
                double area = myRhombus.GetArea();


                Console.WriteLine("P: " + perimeter.ToString("F2"));
                Console.WriteLine("S: " + area.ToString("F2"));



            }
        }
    }

