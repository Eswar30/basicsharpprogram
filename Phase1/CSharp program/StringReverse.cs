using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_program
{
	class StringReverse
	{
		public void Do()
		{
			Console.WriteLine("Please enter a string to reverse");
			string input = Console.ReadLine();

			// String is  a collection of characters
			//for (Initiallization, condition, increment/decrement )
			//Chennai =>iannehc =>7(0-6)
			//start reading from last index/char,
			// store/append it in a separate string
			// Decreament index position

			string result = string.Empty;
			for (int i = input.Length - 1; i >= 0; i--)
			{
				result = result + input[i];
			}
			Console.WriteLine(result);
		}
	}
}
