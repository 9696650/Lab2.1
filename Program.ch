using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    // ---------------------------------------------------------
    // ЧАСТИНА 2: КОНСОЛЬНИЙ ДОДАТОК (Testing)
    // Тут можна використовувати Console.WriteLine / ReadLine
    // ---------------------------------------------------------
    namespace ConsoleApp
    {
        using ShapeLibrary;

        class Program
        {
            static void Main()
            { 

                
                Rhombus myRhombus = new Rhombus(8, 9, 30);

                
                Console.WriteLine(myRhombus.GetInfo());

                
                double perimeter = myRhombus.GetPerimeter();
                double area = myRhombus.GetArea();

               
                Console.WriteLine("Calculated Perimeter: " + perimeter.ToString("F2"));
                Console.WriteLine("Calculated Area: " + area.ToString("F2"));
               

               
            }
        }
    }

}
