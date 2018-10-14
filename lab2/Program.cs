using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!\n");

            double length;
            double width;
            double height;
            
            Console.WriteLine("Please enter the length of the room");
            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the room");
            width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height of the room");
            height = double.Parse(Console.ReadLine());


            double area = length * width;
            double primeter = (2 * length) + (2 * width);
            double volume = length * width * height;

            
            Console.WriteLine($"The area of the room is {area}");
            Console.WriteLine($"The primeter of the room is {primeter}");
            Console.WriteLine($"The volume of the room is {volume}\n");

            Console.WriteLine("Would you like to continue \"y/n\"?");
            string UserInput;
            UserInput = Console.ReadLine();
            if (UserInput.ToLower() == "y")

            {Main();}
            

            else

            {
                Console.WriteLine("Thanks for playing!");
            }

        }
    }
}
            




        
    