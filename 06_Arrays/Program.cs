using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args){
            //string[] colours = {"Kırmızı","Beyaz","Siyah"};

            //Console.WriteLine(colours[2]);

            #region Sample
            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++) { 
                Console.Write("Enter a city name: ");
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------");

            for(int i = 0;i < cities.Length; i++) { 
                Console.WriteLine(cities[i]); 
            }
            #endregion
        }
    }
}
