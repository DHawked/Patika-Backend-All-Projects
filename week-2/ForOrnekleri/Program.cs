using System;

namespace ForOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== FOR DÖNGÜSÜ ÖRNEKLERİ =====\n");

            // 1. Aşama - 10 kere mesaj yazdırma
            Console.WriteLine("1. AŞAMA - Motivasyon Mesajı:");
            Console.WriteLine("-" + new string('-', 50));
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}. Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
            Console.WriteLine();

            // 2. Aşama - 1 ile 20 arasındaki sayılar
            Console.WriteLine("2. AŞAMA - 1 ile 20 Arasındaki Sayılar:");
            Console.WriteLine("-" + new string('-', 50));
            Console.Write("Sayılar: ");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i);
                if (i < 20) Console.Write(", ");
            }
            Console.WriteLine("\n");

            // 3. Aşama - 1 ile 20 arasındaki çift sayılar
            Console.WriteLine("3. AŞAMA - 1 ile 20 Arasındaki Çift Sayılar:");
            Console.WriteLine("-" + new string('-', 50));
            Console.Write("Çift Sayılar: ");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i);
                if (i < 20) Console.Write(", ");
            }
            Console.WriteLine("\n");

            // 4. Aşama - 50 ile 150 arasındaki sayıların toplamı
            Console.WriteLine("4. AŞAMA - 50 ile 150 Arasındaki Sayıların Toplamı:");
            Console.WriteLine("-" + new string('-', 50));
            int toplam = 0;
            for (int i = 50; i <= 150; i++)
            {
                toplam += i;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı: {toplam}");
            Console.WriteLine();

            // 5. Aşama - 1 ile 120 arasındaki tek ve çift sayıların ayrı ayrı toplamları
            Console.WriteLine("5. AŞAMA - 1 ile 120 Arasındaki Tek ve Çift Sayıların Toplamları:");
            Console.WriteLine("-" + new string('-', 50));
            int tekToplam = 0;
            int ciftToplam = 0;
            
            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                }
                else
                {
                    tekToplam += i;
                }
            }
            
            Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {tekToplam}");
            Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {ciftToplam}");
            Console.WriteLine();

            Console.WriteLine("===== PROGRAM SONU =====");
            Console.WriteLine("\nÇıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}