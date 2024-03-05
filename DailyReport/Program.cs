using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displaying a header for the student daily report
            Console.WriteLine("Academy of Learning Career College \nStudent Daily Report.");

            // Asking for the user's name and storing it in the variable UserName
            Console.WriteLine("What is your name?");
            string UserName = Console.ReadLine();

            // Asking for the course name and storing it in the variable CourseName
            Console.WriteLine("What course are you on?");
            string CourseName = Console.ReadLine();

            // Asking for the page number and storing it in the variable PageNumber
            Console.WriteLine("What page number?");
            string PageNumber = Console.ReadLine();
            int PageNumberInt = Convert.ToInt32(PageNumber);

            // Asking if the user needs help and storing the response in the variable HelpNeeded
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string HelpNeeded = Console.ReadLine();

            // Converting the string response to a boolean value and storing it in HelpNeededBool
            bool HelpNeededBool = bool.Parse(HelpNeeded);

            // Asking for positive experiences and storing the response in the variable PositiveExperience
            Console.WriteLine("Were there any positive experiences you'd like to share? Please provide specifics.");
            string PositiveExperience = Console.ReadLine();

            // Asking for additional feedback and storing the response in the variable Feedback
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string Feedback = Console.ReadLine();

            // Asking for the number of hours studied and storing it in the variable HoursStudied
            Console.WriteLine("How many hours did you study today?");
            string HoursStudied = Console.ReadLine();

            // Converting the string representation of hours to an integer and storing it in HoursStudiedInt
            int HoursStudiedInt = Convert.ToInt32(HoursStudied);

            // Displaying a closing message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

            // Waiting for user input before closing the console window
            Console.ReadLine();
        }
    }
}
