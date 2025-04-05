using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    internal class Program{

        static void Main(string[] args){
            
            while (true){
                Console.WriteLine("Welcome to the ATM!");
                Console.Write("Press 1 for register/Press 2 for login:");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1){
                    Console.Write("Please enter your name:");
                    string name = Console.ReadLine();
                    Console.Write("Please enter your surname:");
                    string surname = Console.ReadLine();
                    Console.Write("Please enter your balance:");
                    int balance = Convert.ToInt32(Console.ReadLine());

                    Users user = new Users(name, surname, balance);
                    
                    Console.WriteLine("Registering...");
                    Console.WriteLine($"User {user.getName()} {user.getSurname()} with balance {user.getBalance()} registered successfully.");
                }
                else if (choice == 2){
                    Console.WriteLine("Logging in...");
                    break;
                }
                else{
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }



        }
    }
}
