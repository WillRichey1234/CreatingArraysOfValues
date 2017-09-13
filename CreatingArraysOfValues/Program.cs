using System;

namespace CreatingArraysOfValues
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // the array are 0 based this means you count the arrays as the first numer as 1
            /*  int[] numbers = new int[5];
              //arrays are only able to hold 5 variables you cannot expand or shrink the array once you declare its value

              numbers[0] = 4;
              numbers[1] = 6;
              numbers[2] = 15;
              numbers[3] = 16;
              numbers[4] = 23;

              
            int[] numbers = new int[] { 4, 8, 16, 23, 42 };

			Console.WriteLine(numbers[1].ToString());
			Console.ReadLine();
			*/
            string[] names = new string[] { "eddie", "ALex", "Micheal", "David Lee" };
            // for each will execute this block of code for each of the variables in the array
            foreach( string name in names){
                Console.WriteLine(name);
            }
            Console.ReadLine();

		}
    }
}
