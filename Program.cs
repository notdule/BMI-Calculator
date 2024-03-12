using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BMI Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			// weight / (height*height)
			string weightInput = Console.ReadLine();
			int weight = 0;
			Int32.TryParse(weightInput, out weight);
			Console.WriteLine("Insert Your Height:");
			string heightInput = Console.ReadLine();
			int height = 0; 
			Int32.TryParse(heightInput, out height);
			int result = 0;


			if (weight != null)
			{
				result = weight / (height * height);
				Console.WriteLine(result);
			}
		}
	}
}

