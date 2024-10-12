using System;

namespace temperature_converter.Methods
{
    internal class ApplicationProcess
    {
        public static void StartApplication()
        {
            Console.WriteLine("Hello, World! Welcome to my temperature converter application!");

            try
            {
                MainProcess();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }

        public static void MainProcess()
        {
            bool isRunning = true;

            while (isRunning == true)
            {
                Console.WriteLine("\nSelect start or quit:");

                string action = Console.ReadLine();

                if (action.Equals("Start", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nEnter temperature:");
                    
                    double temperature = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nSelect a temparature scale (celsius, fahrenheit or kelvin):");
                    
                    string userInput = Console.ReadLine();

                    ProcessInput(userInput, temperature);
                }
                else if (action.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nThank you, ending application....");

                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }
        }

        public static void CelsiusToFahrenheit(double temp)
        {
            double celsius = temp;

            double fahrenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine($"\nFahrenheit: {fahrenheit}");
        }

        public static void CelsiusToKelvin(double temp)
        {
            double celsius = temp;

            double kelvin = temp + 273.15;

            Console.WriteLine($"\nKelvin: {kelvin}");
        }

        public static void FahrenheitToCelsius(double temp)
        {
            double fahrenheit = temp;

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"\nCelsius: {celsius}");
        }

        public static void FahrenheitToKelvin(double temp)
        {
            double fahrenheit = temp;

            double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;

            Console.WriteLine($"\nKelvin: {kelvin}");
        }

        public static void KelvinToCelsius(double temp)
        {
            double kelvin = temp;

            double celsius = kelvin - 273.15;

            Console.WriteLine($"\nCelsius: {celsius}");
        }

        public static void KelvinToFahrenheit(double temp)
        {
            double kelvin = temp;

            double fahrenheit = 1.8 * (kelvin - 273.15) + 32;

            Console.WriteLine($"\nFahrenheit: {fahrenheit}");
        }

        public static void ProcessInput(string input, double temp)
        {
            if (input.Equals("Celsius", StringComparison.OrdinalIgnoreCase))
            {
                ProcessCelsius(temp);
            }
            else if (input.Equals("Fahrenheit", StringComparison.OrdinalIgnoreCase))
            {
                ProcessFahrenheit(temp);
            }
            else if (input.Equals("Kelvin", StringComparison.OrdinalIgnoreCase))
            {
                ProcessKelvin(temp);
            }
            else
            {
                Console.WriteLine("Incorerect input!");
            }
        }

        public static void ProcessCelsius(double temp)
        {
            Console.WriteLine($"Celsius: {temp}");

            Console.WriteLine("\nConvert to fahrenheit or kelvin:");

            string convertTo = Console.ReadLine();

            if (convertTo.Equals("Fahrenheit", StringComparison.OrdinalIgnoreCase))
            {
                CelsiusToFahrenheit(temp);
            }
            else if (convertTo.Equals("Kelvin", StringComparison.OrdinalIgnoreCase))
            {
                CelsiusToKelvin(temp);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }

        public static void ProcessFahrenheit(double temp)
        {
            Console.WriteLine($"Fahrenheit: {temp}");

            Console.WriteLine("\nConvert to celsius or kelvin:");

            string convertTo = Console.ReadLine();

            if (convertTo.Equals("Celsius", StringComparison.OrdinalIgnoreCase))
            {
                FahrenheitToCelsius(temp);
            }
            else if (convertTo.Equals("Kelvin", StringComparison.OrdinalIgnoreCase))
            {
                FahrenheitToKelvin(temp);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }

        public static void ProcessKelvin(double temp)
        {
            Console.WriteLine($"Kelvin: {temp}");

            Console.WriteLine("\nConvert to celsius or fahrenheit:");

            string convertTo = Console.ReadLine();

            if (convertTo.Equals("Celsius", StringComparison.OrdinalIgnoreCase))
            {
                KelvinToCelsius(temp);
            }
            else if (convertTo.Equals("Fahrenheit", StringComparison.OrdinalIgnoreCase))
            {
                KelvinToFahrenheit(temp);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
