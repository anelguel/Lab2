using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	/*Lab 2
	 * Task: Use conditional statements to automate decision making.
	 * The application will:
	 * 1. Ask for user input between 1 and 100.
	 * 2. Display the associated result based on the interger range entered.
	 * 3. Prompt the user to continue.
	 * Build specifications:
	 * 1. Use if/else statements to take different actions depending on user input.
	*/
	class Program
	{
		static void Main(string[] args)
		{
			bool run = true;
			while (run == true)
			{
				Console.WriteLine("Enter a number between 1 and 100:");
				int input = Int32.Parse(Console.ReadLine());

				if (input % 2 != 0 && input <= 60 && input >= 0)
				{
					Console.WriteLine(input + " is an odd number and less than 60.");
				}
				else if (input % 2 == 0 && input >= 2 && input <= 25)
				{
					Console.WriteLine(input + " is between 2 and 25 and an even number.");
				}
				else if (input % 2 == 0 && input >= 26 && input <= 60)
				{
					Console.WriteLine(input + " is between 26 and 60 and an even number.");
				}
				else if (input % 2 == 0 && input >= 60 && input <= 100)
				{
					Console.WriteLine(input + " is between 60 and 100 and an even number.");
				}
				else if (input % 2 != 0 && input >= 60 && input <=100)
				{
					Console.WriteLine(input + " is greater than 60 and an odd number.");
				}
				else 
				{
					Console.WriteLine("That is not a number between 1 and 100.");
				}
				run = Continue();
			}
		}
		public static bool Continue()
		{
			Console.WriteLine("Do you wish to continue? y/n");
			string input = Console.ReadLine();
			input = input.ToLower();
			bool goOn;
			if (input == "y")
			{
				goOn = true;
			}
			else if (input == "n")
			{
				goOn = false;
			}
			else
			{
				Console.WriteLine("I don't understand that, let's try again");
				goOn = Continue();
			}
			return goOn;
		}
	}
}
