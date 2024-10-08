using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Introduction
{
    internal class Program
    {
        static void Main(string[] args){
            //Console.WriteLine("Hello world");

            #region Introduction
            //Console.WriteLine("***** Yemek Kategorileri *****" + "\n");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler" + "\n");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region StringVariables
            string customerName = "Ali";
            string customerSurname = "Çınar";
            string customerPhone = "+90 500 400 30 20";
            string customerMail = "deneme@gmail.com";
            string district = "Kadıköy";
            string city = "İstanbul";

            Console.WriteLine("***** Rezervasyon Kartı *****" + "\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerMail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("------------------------------");

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 400 300 20 10";
            customerMail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine("------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerMail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("------------------------------");

            #endregion

        }
    }
}
