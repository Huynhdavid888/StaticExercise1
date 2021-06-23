using System;

namespace StaticExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(95);
            var fahrenheit = TempConverter.CelciusTofahrenheit(35);

            Console.WriteLine($"celcius{celcius}");
            Console.WriteLine($"Fahrenheit{fahrenheit}");
        }
        
        
    }
}
