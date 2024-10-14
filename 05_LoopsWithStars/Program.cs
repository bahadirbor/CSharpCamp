using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args){

            #region SampleOne
            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region SampleTwo
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region SampleThree
            //for(int j = 0; j < 10; j++)
            //{
            //    for(int i = 0; i < 10; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}

            #endregion

            #region SampleFour
            //for(int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region SampleFive
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region SamplePyramid
            //int n = 5;

            //for (int i = 1; i <= n; i++) { 
            //    //spaces
            //    for (int j = n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //stars
            //    for (int k = 1; k <= 2 * i - 1; k++) { 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

        }
    }
}
