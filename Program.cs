using System;
namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("**************");
            
            Console.Write("First Name : ");
            string fName = Console.ReadLine();
            Console.Write("Middle Name : ");
            string mName = Console.ReadLine();
            Console.Write("Last Name : ");
            string lName = Console.ReadLine();
            Console.Write("Weight(kg) : ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height(m) : ");
            double height = Convert.ToDouble(Console.ReadLine());
            
            double heightsqr = height * 2;
            double bmi = weight / heightsqr;
            
            Console.WriteLine("BMI : " + bmi);
            
            if (bmi < 18.5)
            {
                Console.WriteLine("Your BMI Status: Underweight");
            }
            
            
            
            
            
        }
    }
}
