using System;

namespace minimumNumber
{
    class Minimum{
        public void Min(int num1 ,int num2,int num3){
            if(num1 < num2 && num1 < num3){
                Console.WriteLine(num1 + " is the minimum value");
            }
			if (num2 < num1 && num1 < num3)
			{
				Console.WriteLine(num2 + " is the minimum value");
			}
			if (num3 < num1 && num1 < num2)
			{
				Console.WriteLine(num3 + " is the minimum value");
			}
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Hello World! \n please enter 3 numbers to find the minimum value");

            //finding minimum of 3 numbers
			Minimum ob = new Minimum();
            int a, b, c;
            a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());

            Console.WriteLine();


            ob.Min(a, b, c);
		}
    }
}
