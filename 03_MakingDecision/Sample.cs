using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Sample
    {
        public static void Restaurant()
        {
            Console.WriteLine("***** C# Camp Restaurant *****" + "\n");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("------------------------------" + "\n");

            Console.Write("Kategorilerdeki seçenekleri görmek için sayıyı yazınız: ");
            int decision = int.Parse(Console.ReadLine());

            if (decision == 1)
            {
                Console.WriteLine("***** Çorbalar *****");
                Console.WriteLine("- Mercimek");
                Console.WriteLine("- Ezogelin");
                Console.WriteLine("- Kelle");
                Console.WriteLine("- Domates");
            }
            else if (decision == 2)
            {
                Console.WriteLine("***** Ana Yemekler *****");
                Console.WriteLine("- Adana Kebap");
                Console.WriteLine("- Köri Soslu Tavuk");
                Console.WriteLine("- Fırında Somon");
                Console.WriteLine("- Patlıcan Musakka");
            }
            else if (decision == 3)
            {
                Console.WriteLine("***** Pizzalar *****");
                Console.WriteLine("- Karışık Pizza");
                Console.WriteLine("- Tavuklu Pizza");
            }
            else if (decision == 4)
            {
                Console.WriteLine("***** İçecekler *****");
                Console.WriteLine("- Su");
                Console.WriteLine("- Kola");
                Console.WriteLine("- Ayran");
            }
            else if (decision == 5) {
                Console.WriteLine("***** Tatlılar *****");
                Console.WriteLine("- Baklava");
                Console.WriteLine("- Güllaç");
                Console.WriteLine("- Kadayıf");
            }

            
        }
        
        public Sample() {
            Restaurant();
        }
    }
}
