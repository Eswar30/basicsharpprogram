using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_program
{
	class EvenOdd
	{
		public void Do()
		{
			Console.WriteLine("Please enter a number to find if it is odd or even or enter 0 to exit");
			bool keepRunning = true;
			// while (<expression> = true /false )
			while (keepRunning)
			{
				string input = Console.ReadLine();


				// how to convert one datatype to other datatype 
				int value = Convert.ToInt32(input);
				if (value == 0)
				{
					keepRunning = false;
					break;
				}

				//check if odd or even 
				if (value % 2 == 0)
				{
					Console.WriteLine("This is even");
				}
				else
				{
					Console.WriteLine("This is odd");
				}
			}
		}
	}
}
