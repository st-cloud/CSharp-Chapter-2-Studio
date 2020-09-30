using System;

namespace CircleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //circle calculations
            Console.WriteLine("Enter circle radius:");
            string input = Console.ReadLine();
            double radius = double.Parse(input);

            double area = 3.14 * radius * radius;
            double circumference = 2 * 3.14 * radius;
            double diameter = 2 * radius;

            Console.WriteLine("Area: " + area + " units squared");
            Console.WriteLine("Circumference: " + circumference);
            Console.WriteLine("Diameter: " + diameter);

            //car calculation
            Console.WriteLine("Enter miles per gallon of your car:");
            string inputTwo = Console.ReadLine();
            double milesPerGallon = double.Parse(inputTwo);
            double gasUsed = circumference / milesPerGallon;

            Console.WriteLine("Gas used to drive around circle: " + gasUsed + "gallons");
            Console.ReadLine();
        }
    }
}
