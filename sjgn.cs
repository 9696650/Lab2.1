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


                Rhomb myRhomb = new Rhomb(8, 9, 5);


                Console.WriteLine(myRhomb.GetInfo());


                double perimeter = myRhomb.GetPerimeter();
                double area = myRhombus.GetArea();


                Console.WriteLine("P: " + perimeter.ToString("F2"));
                Console.WriteLine("S: " + area.ToString("F2"));



            }
        }
    }

