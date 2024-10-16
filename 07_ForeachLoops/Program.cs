using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args){
            Console.Write("Enter the array limit: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] numbers = new int[arrayLength];
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i < arrayLength; i++) {
                Console.Write("Insert your number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in numbers) {
                if (number % 2 == 0)
                {
                    even.Add(number);
                }
                else if (number % 2 == 1) { 
                    odd.Add(number);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Odd numbers");
            
            for(int j = 0; j < odd.Count; j++)
            {
                Console.WriteLine(odd[j]);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Even numbers");

            for (int j = 0; j < even.Count; j++)
            {
                Console.WriteLine(even[j]);
            }


        }
    }
}
