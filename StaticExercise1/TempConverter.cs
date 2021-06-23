using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise1
{
    public static class TempConverter
    {
        public static double FahrenheitToCelcius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;

            return result;
        }
        
            public static double CelciusTofahrenheit(double celcius)

        { 
            return (celcius * 9) / 5 + 32;
        }
        
        
    }
}
