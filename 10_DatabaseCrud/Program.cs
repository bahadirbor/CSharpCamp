using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    // CRUD -> Create, Read, Update, Delete
    class Program
    {
        static void Main(string[] args)
        {
            #region Ürün Ekleme
            //Console.WriteLine("***** Menü Sipariş İşleme Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("------------------------------------");
            //Console.Write("Eklenecek kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connect = new SqlConnection("data source=;initial catalog=;integrated security=");

            //connect.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO Category(CategoryName) VALUES (@p1)", connect);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connect.Close();

            //Console.WriteLine("Kategori Eklendi");       
            #endregion

            #region Ürün Listeleme
            //SqlConnection connection = new SqlConnection(/*"Data source=;initial catalog=;integrated security="*/);

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From Category", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //foreach (DataRow row in table.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region Ürün Silme
            //SqlConnection connect = new SqlConnection("data source=;initial catalog=;integrated security=");

            //Console.Write("ID giriniz: ");
            //string id = Console.ReadLine();

            //connect.Open();
            //SqlCommand command = new SqlCommand("DELETE FROM Category WHERE CategoryId=@id", connect);
            //command.Parameters.AddWithValue("@id", id);
            //command.ExecuteNonQuery();

            //connect.Close();


            #endregion




        }
    }
}
