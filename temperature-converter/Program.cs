using System;

namespace temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to my temperature converter application:\n");

            bool isRunning = true;

            while (isRunning == true)
            {
                Console.WriteLine("Enter temperature:");

                double temperature = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Is this (1) Celsius, (2) Fahrenheit or, (3) Kelvin:");

                string tempType = Console.ReadLine();

                if (tempType == "Celsius" || tempType == "1")
                {
                    Console.WriteLine($"Celsius: {temperature}");

                    Console.WriteLine("Convert to Fahrenheit or Kelvin:");

                    string convertTo = Console.ReadLine();

                    if (convertTo == "Fahrenheit")
                    {
                        double celsius = temperature;

                        double fahrenheit = (celsius * 9) / 5 + 32;

                        Console.WriteLine($"Fahrenheit: {fahrenheit}");
                    } 
                    else if (convertTo == "Kelvin")
                    {
                        double celsius = temperature;

                        double kelvin = temperature + 273.15;

                        Console.WriteLine($"Kelvin: {kelvin}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                }
                else if (tempType == "Fahrenheit" || tempType == "2")
                {
                    Console.WriteLine($"Fahrenheit: {temperature}");

                    Console.WriteLine("Convert to Celsius or Kelvin:");

                    string convertTo = Console.ReadLine();

                    if (convertTo == "Celsius")
                    {

                    }
                    else if (convertTo == "Kelvin")
                    {

                    }
                }
                else if (tempType == "Kelvin" || tempType == "3")
                {
                    Console.WriteLine($"Kelvin: {temperature}");

                    Console.WriteLine("Convert to Celsius or Fahrenheit:");

                    string convertTo = Console.ReadLine();

                    if (convertTo == "Celsius")
                    {

                    }
                    else if (convertTo == "Kelvin")
                    {

                    }
                }
                else
                {
                    Console.WriteLine("Incorerect input");
                }
            }
        }
    }
}
