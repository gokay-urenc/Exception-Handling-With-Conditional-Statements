using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Program
    {
        static void Main(string[] args)
        {
            int fiyat = 0;
            Console.Write("RESTORAN\n\nPilav: 5 TL, İskender: 10 TL\n\nYemek tercihi yapınız: ");
            string tercih = Console.ReadLine();
            if (tercih == "pilav" || tercih == "Pilav" || tercih == "PİLAV")
            {
                try
                {
                    fiyat += 5;
                    Console.Write("\nKaç adet istersiniz: ");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    fiyat = fiyat * adet;
                    Console.Write("Toplam ücretiniz: " + fiyat + " TL");
                }
                catch (FormatException)
                {
                    Console.Write("\nBir adet girmeliydiniz.");
                }
            }
            else if (tercih == "iskender" || tercih == "İskender" || tercih == "İSKENDER")
            {
                try
                {
                    fiyat += 10;
                    Console.Write("\nKaç adet istersiniz: ");
                    int adet = Convert.ToInt32(Console.ReadLine());
                    fiyat = fiyat * adet;
                    Console.Write("\nToplam ücretiniz: " + fiyat + " TL");
                }
                catch (FormatException)
                {
                    Console.Write("\nBir adet girmeliydiniz.");
                }
            }
            else
            {
                Console.Write("\nMenüde böyle bir yemek bulunmamaktadır.");
            }
            Console.ReadKey();
        }
    }
}