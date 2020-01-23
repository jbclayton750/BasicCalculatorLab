using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature in Fahrenheit");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the relative humidity");
            int secondNumber = int.Parse(Console.ReadLine());
                        
            int sum = firstNumber - ((9*(100-secondNumber))/25);

            Console.WriteLine("The dew point is " + sum);

            Console.WriteLine("Enter the wind speed");
            int thirdNumber = int.Parse(Console.ReadLine());

            int windchill = 35.74 + (0.6125*firstNumber);
        }
    }
}
