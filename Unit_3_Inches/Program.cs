using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3_Inches
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить расстояние от Земли до Солнца в дюймах
            long inches = 5280 * 12;
            long miles = 93000000;

            inches = inches * miles;
            Console.WriteLine("Расстояние до Солнца {0} дюймов", inches);
        }
    }
}
