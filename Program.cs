using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the GradeCalculator class
            GradeCalculator gradeCalculator = new GradeCalculator();

            float grade = gradeCalculator.GetUserGrade();

           
            string letterGrade = gradeCalculator.GetLetterGrade(grade);

           
            gradeCalculator.DisplayLetterGrade(letterGrade);


            // Create an instance of the TicketPriceCalculator class
            TicketPriceCalculator ticketPriceCalculator = new TicketPriceCalculator();

         
            int age = ticketPriceCalculator.GetUserAge();

         
            decimal price = ticketPriceCalculator.CalculateTicketPrice(age);

            
            ticketPriceCalculator.DisplayTicketPrice(price);


            // Create an instance of the TriangleTypeIdentifier class
            TriangleTypeIdentifier triangleTypeIdentifier = new TriangleTypeIdentifier();

          
            var (side1, side2, side3) = triangleTypeIdentifier.GetTriangleSidesFromUser();

           
            string triangleType = triangleTypeIdentifier.DetermineTriangleType(side1, side2, side3);

           
            triangleTypeIdentifier.DisplayTriangleType(triangleType);
        }
    }
}