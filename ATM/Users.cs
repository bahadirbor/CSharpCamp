using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Users
    {
        // Private variables
        private string Name;
        private string Surname;
        private int Balance = 0;

        //Constructor
        public Users(string name, string surname, int balance)
        {
            this.Name = name;
            this.Surname = surname;
            this.Balance = balance;
        }

        // Variable get functions
        internal string getName() { return Name; }
        internal string getSurname() { return Surname; }
        internal int getBalance() { return Balance; }

        // Variable set functions
        internal void setName(string newName) { Name = newName; }
        internal void setSurname(string newSurname) { Surname = newSurname; }
        internal void setBalance(int newBalance) { Balance = newBalance; }

    }
}
