using System;

public class Program
{
    public static void Main()
    {
        do
        {
            Console.WriteLine("Zadej počet hvězdiček:");
            string vstup = Console.ReadLine();
            int pocetHvezdicek;

            if (!int.TryParse(vstup, out pocetHvezdicek))
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo.");
                continue; 
            }

            for (int i = 0; i < pocetHvezdicek; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine(); 

            Console.WriteLine("Chcete spustit program znovu? (ano/ne)");
        } while (Console.ReadLine().ToLower() == "ano");
    }
}
