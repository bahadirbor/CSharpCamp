using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM
{
    internal class Program{

        static void Main(string[] args){

            Users user;
            
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            Console.Write("Please enter your surname:");
            string surname = Console.ReadLine();
            Console.Write("Please enter your balance:");
            int balance = Convert.ToInt32(Console.ReadLine());

            user = new Users(name, surname, balance);
                    
            Console.WriteLine("Registering...");
            Console.WriteLine($"User {user.getName()} {user.getSurname()} with balance {user.getBalance()} registered successfully.");
            Console.WriteLine("Logging in...");

            int choose;
            Console.WriteLine("1. Examine your bank account");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Deposit Money");
            Console.Write("Make your choice: ");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose){
                case 1:
                    Console.WriteLine("Name - Surname: " + user.getName() + " " + user.getSurname());
                    Console.WriteLine("Balance: " + user.getBalance());
                    break;
                case 2:
                    Console.Write("How much money do you withdraw?: ");
                    int withdraw = Convert.ToInt32(Console.ReadLine());
                    if (withdraw > user.getBalance())
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    else
                    {
                        user.setBalance(user.getBalance() - withdraw);
                        Console.WriteLine("You have withdrawn " + withdraw + " successfully.");
                        Console.WriteLine("Your new balance is: " + user.getBalance());
                    }
                    break;
                case 3:
                    Console.Write("How much money do you deposit?: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    user.setBalance(user.getBalance() + deposit);
                    Console.WriteLine("Your new balance is: " + user.getBalance());
                    break;
                default:
                    Console.WriteLine("You made wrong decision!");
                    break;
                }
        }
    }
}
