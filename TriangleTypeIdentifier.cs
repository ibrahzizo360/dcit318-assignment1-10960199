using System;

namespace MyApp
{
    public class TriangleTypeIdentifier
    {
        // Method to get the sides of the triangle from the user
        public (double, double, double) GetTriangleSidesFromUser()
        {
            double side1 = GetSide("Enter the length of the first side: ");
            double side2 = GetSide("Enter the length of the second side: ");
            double side3 = GetSide("Enter the length of the third side: ");
            return (side1, side2, side3);
        }

        // Method to prompt user for a side length and validate it
        private double GetSide(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (double.TryParse(input, out double side) && side > 0)
                {
                    return side;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }
        }

        // Method to determine the type of triangle based on its sides
        public string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }

        // Method to display the type of triangle
        public void DisplayTriangleType(string type)
        {
            Console.WriteLine($"The triangle is: {type}");
        }
    }
}