using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise5422
{
    public static class TempConverter
    {

        public static double FarenheitToCelsius(double Farenheit) 
        {
            double Celsius = (Farenheit - 32) * 5/9 ;
            return Celsius;
        }

        public static double CelsiusToFarenheit(double Celsius)
        { 
            double Farenheit = (Celsius * 9/5) + 32;
            return Farenheit;
        }

    }
}
