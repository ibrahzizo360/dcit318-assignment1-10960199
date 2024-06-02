using System;

namespace MyApp
{
    public class GradeCalculator
    {
        // Method to get the numerical grade from the user
        public float GetUserGrade()
        {
            while (true)
            {
                Console.Write("Enter a numerical grade between 0 and 100: ");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float grade) && grade >= 0 && grade <= 100)
                {
                    return grade;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
                }
            }
        }

        // Method to determine the letter grade based on the numerical grade
        public string GetLetterGrade(float grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        // Method to display the letter grade
        public void DisplayLetterGrade(string letterGrade)
        {
            Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
        }
    }
}