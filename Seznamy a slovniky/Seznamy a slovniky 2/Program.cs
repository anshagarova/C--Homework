using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot
        List<string> colors = new List<string> { "červená", "modrá", "zelená", "žlutá", "fialová" };

        // 4. Smaž z tohoto listu libovolnou hodnotu
        colors.Remove("fialová");

        // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí metody Contains
        string searchColor = "žlutá";
        bool containsColor = colors.Contains(searchColor);
        Console.WriteLine($"List {(containsColor ? "obsahuje" : "neobsahuje")} hodnotu '{searchColor}'.");

        // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty
        Console.Write($"Počet prvků v listu: {colors.Count}, prvky: ");
        foreach (string color in colors)
        {
            Console.Write(color + ", ");
        }
        Console.WriteLine();
    }
}
