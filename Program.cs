using System;

namespace StaticExercise5422
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We're going to do a tempurature conversion today");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Let's start with Farenheit to Celsius");
            Console.WriteLine();
            Console.WriteLine("Pick any number");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Nice! Let's see what " + firstNumber + " converts to");
            Console.ReadKey();

            var Celsius = TempConverter.FarenheitToCelsius(firstNumber);

            Console.WriteLine($"Looks like " + firstNumber + " degrees Farenheit converts to " + Celsius + " degrees Celsius!");
            Console.ReadKey ();
            
            Console.WriteLine("Now let's do Celsius to Farenheit");
            Console.WriteLine();
            Console.WriteLine("Pick any number");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Nice! Let's see how " + secondNumber + " converts");
            Console.ReadKey();

            var Farenheit = TempConverter.CelsiusToFarenheit(secondNumber);

            Console.WriteLine($"Looks like " + secondNumber + " degrees Celsius converts to " + Farenheit + " degrees Farenheit!");
            Console.ReadKey();

        }
    }
}
