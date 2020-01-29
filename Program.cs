using System;

namespace lab3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[] { "Abby", "Brad", "Charlie", "Dianne", "Edith", "Francine", "Greg", "Haley", "Ilsa", "John"};
            string[] faveCandy = new string[] { "Almond Joy", "Butterfinger", "Dots", "Crunch Bar", "English Toffee", "Fun Dip", "Gummy Bears", "Heath Bar", "Ice Breakers Gum", "Jaw Breakers" };
            string[] prevTitle = new string[] { "Athlete", "Business Analyst", "Cop", "Dance Teacher", "Educator", "Flight Attendant", "Gym Teacher", "High School Teacher", "Ice Skater", "" };
            string goAgain = "yes";

            Console.WriteLine("Welcome to our Dev.Build Class!");
            Console.Write("Would you like to see a list of the students: (yes/no)");
            string seeList = Console.ReadLine();
            if (seeList == "yes")
            {
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {students[i]}");
                }
            }
            do
            {
                int x = GetInt("Which student would you like to learn more about? (Enter a student number from 1 - 10): ");
                

                if (x  > students.Length)
                {
                    Console.WriteLine("That student does not exist in our database. Please try a student number from 1 - 10 or if you would like to Exit, press 0: ");
                    continue;      
                }
                else if (x <= students.Length && x > 0)
                {
                    Console.WriteLine($"Student {x} is {students[x - 1]}");
                }
                else
                {
                    
                    break;
                    
                }
                do
                {
                    Console.Write($"What would you like to know about {students[x - 1]}? Please enter favorite candy or previous title: ");
                    string input = Console.ReadLine();
                    input = input.ToLower();

                    if (input == "favorite candy")
                    {
                        Console.WriteLine($"{ students[x - 1]}'s favorite candy is {faveCandy[x - 1]}");
                    }
                    else if (input == "previous title")
                    {
                        Console.WriteLine($"{ students[x - 1]}'s previous title was {prevTitle[x - 1]}");
                    }
                    else
                    {
                        Console.WriteLine("That data does not exist. Please try again");
                        continue;

                    }
                    Console.Write($"Would you like to know anything else about {students[x - 1]}?: ");
                  
                    goAgain = Console.ReadLine();
                    if (goAgain == "no")
                    {
                        break;
                    }
                } while (goAgain == "yes");

                Console.Write("Would you like to know about any other students? (yes/no)");
                goAgain = Console.ReadLine();
            }while (goAgain == "yes");
            Console.WriteLine("Thank you for your interest in our students. Goodbye!");
        }

        static int GetInt(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }


    }
}
