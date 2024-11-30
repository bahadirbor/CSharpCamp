using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Adding{
        public void AddItem()
        {
            SqlConnection connection = new SqlConnection(/*Insert your database address*/);
            string categoryName;

            Console.Write("Category Name:");
            categoryName = Console.ReadLine();

            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Category (CategoryName) VALUES (@categoryname)", connection);
            command.Parameters.AddWithValue("@categoryname", categoryName);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Category added");
            
        } 
    }
}
