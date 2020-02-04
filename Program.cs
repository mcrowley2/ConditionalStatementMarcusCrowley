using System;

namespace ConditionalStatementMarcusCrowley
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instruct user to type expected grade for the course
            Console.WriteLine("Enter what total score out of 100 you expect to get in ISM 4300. No % sign.");

            // Declare local variables; User should be able to enter an integer
            int grade = Convert.ToInt32(Console.ReadLine());
            string lettergrade = "";

            // Create if-else statement to determine letter grade based on expected course grade
            if (grade >= 98 && grade <= 100)
            {
                lettergrade = "A+";
            }
            else if (grade >= 92 && grade <= 97)
            {
                lettergrade = "A";
            }
            else if (grade == 90 || grade == 91)
            {
                lettergrade = "A-";
            }
            else if (grade == 88 || grade == 89)
            {
                lettergrade = "B+";
            }
            else if (grade >= 82 && grade <= 87)
            {
                lettergrade = "B";
            }
            else if (grade == 80 || grade == 81)
            {
                lettergrade = "B-";
            }
            else if (grade == 79 || grade == 78)
            {
                lettergrade = "C+";
            }
            else if (grade >= 72 && grade <= 77)
            {
                lettergrade = "C";
            }
            else if (grade == 70 || grade == 71)
            {
                lettergrade = "C-";
            }
            else if (grade == 69 || grade == 68)
            {
                lettergrade = "D+";
            }
            else if (grade >= 62 && grade <= 67)
            {
                lettergrade = "D";
            }
            else if (grade == 60 || grade == 61)
            {
                lettergrade = "D-";
            }
            else if (grade >= 0 && grade < 60)
            {
                lettergrade = "F";
            }
            // If no integer is entered between 0 and 100, it's determined to be an invalid entry
            else
            {
                lettergrade = "Invalid Entry";
            }

            // Create if-else statement to determine a response to what the user enters
            if (lettergrade == "Invalid Entry")
            {
                Console.WriteLine("Invalid Entry: Number must be between 0 and 100.");
            }
            else
            {
                Console.WriteLine("Per Syllabus, your letter grade for this course is {0}", lettergrade);
            }
        }
    }
}
