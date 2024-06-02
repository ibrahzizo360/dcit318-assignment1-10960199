using System;

namespace MyApp
{
    public class TicketPriceCalculator
    {
        private const decimal RegularPrice = 10.0m;
        private const decimal DiscountedPrice = 7.0m;

        // Method to get the age from the user
        public int GetUserAge()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age) && age >= 0)
                {
                    return age;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                }
            }
        }

        // Method to calculate the ticket price based on age
        public decimal CalculateTicketPrice(int age)
        {
            if (age <= 12 || age >= 65)
            {
                return DiscountedPrice;
            }
            else
            {
                return RegularPrice;
            }
        }

        // Method to display the ticket price
        public void DisplayTicketPrice(decimal price)
        {
            Console.WriteLine($"The ticket price is: GHC{price}");
        }
    }
}