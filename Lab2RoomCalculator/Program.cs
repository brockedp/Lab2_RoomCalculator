using System;

namespace Lab2RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            bool keepGoing = true;
            while (keepGoing)
            {
                // input -- receive two numbers
                // prompt
                Console.Write("Enter width: ");
                // received
                double width = double.Parse(Console.ReadLine());

                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());

                // process - calculate area and perimeter of room
                double area = length * width;
                double perimeter = (length  + width) * 2;
                double volume = length * height * width;


                // output
                Console.WriteLine("The area of the room is {0}\nThe perimeter of the room is {1}\nThe volume of the room is {2}", area, perimeter,volume);


                bool calcAgain = true;
                while(calcAgain)
                {
                    Console.Write("Do you want to calculate the size of another room?(y/n): ");
                    string answer = Console.ReadLine().ToLower(); 
                    if (answer == "y")
                    {
                        calcAgain = false;
                    }
                    else if (answer == "n")
                    {
                        keepGoing = false;
                        calcAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("I don't understant that input. Please type y for yes and n for no.");
                        calcAgain = true;
                    }
                }
            }
            Console.WriteLine("Goodbye!");
                
        }
    }
}
