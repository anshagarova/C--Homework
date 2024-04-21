using System;

public class Program
{
    public static void Main()
    {
        Random random = new Random();
        int cislo = random.Next(1, 101); // Generuje náhodné číslo od 1 do 100
        int tip;

        Console.WriteLine("Myslím si číslo od 1 do 100. Hádej!");

        do
        {
            Console.Write("Hádej číslo: ");
            string vstup = Console.ReadLine();

            // Zkusíme převést vstup na celé číslo
            if (!int.TryParse(vstup, out tip))
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím celé číslo.");
                continue;
            }

            if (tip < cislo)
            {
                Console.WriteLine("Číslo je větší, hádej znovu.");
            }
            else if (tip > cislo)
            {
                Console.WriteLine("Číslo je menší, hádej znovu.");
            }
            else
            {
                Console.WriteLine("To je správně!");
                break; // Ukončíme smyčku, pokud uživatel uhádl číslo
            }
        } while (true);
    }
}
