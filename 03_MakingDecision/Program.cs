using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            //double exam, exam2, exam3, average = 0;

            //Console.Write("Input your exam result: ");
            //exam = double.Parse(Console.ReadLine());

            //Console.Write("Input your exam result: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Input your exam result: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam + exam2 + exam3) / 3;

            //if (average >= 50)
            //{
            //    Console.WriteLine("Your average exam score: " + average);
            //    Console.WriteLine("You have succeed");
            //}
            //else if (average < 50)
            //{
            //    Console.WriteLine("Your average exam score: " + average);
            //    Console.WriteLine("You have failed");
            //}
            //else {
            //    Console.WriteLine("ERROR");
            //}
            #endregion

            #region CharDecisions
            //char team;
            //Console.Write("Takım Sembolü girin: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' |  team == 'G'){
            //    Console.WriteLine("Galatasaray");
            //}
            //else if(team == 'b' |  team == 'B'){
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if(team == 'f' | team == 'F'){
            //    Console.WriteLine("Fenerbahçe");
            //}
            #endregion

            #region SampleProject
            //Sample sample = new Sample();
            #endregion

            #region SwitchCase

            Console.Write("Seçeğiniz ayın sayı bilgisini girin: ");
            int decision = int.Parse(Console.ReadLine());

            switch (decision) {
                case 1: Console.WriteLine("Ocak"); break;
                case 2: Console.WriteLine("Şubat"); break;
                case 3: Console.WriteLine("Mart"); break;
                case 4: Console.WriteLine("Nisan"); break;
                case 5: Console.WriteLine("Mayıs"); break;
                case 6: Console.WriteLine("Haziran"); break;
                case 7: Console.WriteLine("Temmuz"); break;
                case 8: Console.WriteLine("Ağustos"); break;
                case 9: Console.WriteLine("Eylül"); break;
                case 10: Console.WriteLine("Ekim"); break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;
                default: Console.WriteLine("Geçersiz sayı"); break;
            }
            
            
            #endregion

        }
    }
}
