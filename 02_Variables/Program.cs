using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program{
        static void Main(string[] args){
            //double number = 4.85;

            #region DoubleVariables
            //Console.WriteLine("***** Fiyat Listesi *****" + "\n");

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.68;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL" + "\n");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("***** Ürün Listesi *****");

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " +
            //    appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " +
            //    orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " +
            //    strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " +
            //    potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " +
            //    tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice +
            //    tomatoTotalPrice;

            //Console.WriteLine("Toplam Tutar: " + shoppingTotalPrice);

            #endregion

            #region CharVariables
            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region StringInputOperations
            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");

            //string passengerName, passengerSurname, passengerDistrict, passengerAge,
            //    passengerCity, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçesi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu İl: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Tc Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");

            //Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentityNumber + " - Yolcu Ad Soyad: " + passengerName + " " + 
            //    passengerSurname + " - Yolcu Yaş: " + passengerAge + " - Yolcu İlçe/İl: " + passengerDistrict + "/" + passengerCity);

            #endregion

            #region IntegerInputOperations
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = tvCount * tvPrice + chairCount * chairPrice
            //    + computerCount * computerPrice + shoesCount * shoesPrice;

            //Console.WriteLine("\nToplam Tutar : " + totalPrice);

            #endregion

            #region DoubleInputOperations
            //double exam1, exam2, exam3, average;

            //Console.Write("1. Sınav Sonucu: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Sonucu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Sonucu: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sonuç: " + average);

            #endregion

            #region CharInputOperations
            //char gender;

            //Console.Write("Cinsiyet seçin: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
            
            #endregion
        }
    }
}
