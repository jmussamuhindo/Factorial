using System;
using System.Collections.Generic;
namespace myAssignment
{
    class Assignment5
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enters size of array please: ");
            int n = int.Parse(Console.ReadLine());
            
            List<Int32> numbers = new List<Int32>();
            int number1 = 1, number2 = 0, number3 = 5;
            for (int i = 0; i < n; i++)
                numbers.Add(int.Parse(Console.In.ReadLine()));

            for(int i=0; i<n; i++)
            {
                while (number1 != 0)
                {   
                    number2 = number2 + numbers[i] / number3;
                    number1 = numbers[i] / number3;
                    number3 *=5;
                }
                number1 = 1;
                number3 = 5;
                Console.WriteLine(number2);
                number2 = 0;
            }
        }
    }
}
