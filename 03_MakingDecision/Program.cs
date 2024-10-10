using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args){
            #region If
            /*string password;

            Console.Write("Insert your password: ");
            password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Password is correct!");
            }
            else
            {
                Console.WriteLine("Password is incorrect or innvalid");
            }*/
            #endregion

            #region ElseIf
            double exam, exam2, exam3, average = 0;

            Console.Write("Input your exam result: ");
            exam = double.Parse(Console.ReadLine());

            Console.Write("Input your exam result: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Input your exam result: ");
            exam3 = double.Parse(Console.ReadLine());

            average = (exam + exam2 + exam3) / 3;

            if (average >= 50)
            {
                Console.WriteLine("Your average exam score: " + average);
                Console.WriteLine("You have succeed");
            }
            else if (average < 50)
            {
                Console.WriteLine("Your average exam score: " + average);
                Console.WriteLine("You have failed");
            }
            else {
                Console.WriteLine("ERROR");
            }
            #endregion
        }
    }
}
