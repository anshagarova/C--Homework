using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty
        Dictionary<string, double> shoppingList = new Dictionary<string, double>();
        shoppingList.Add("chleba", 20);
        shoppingList.Add("mléko", 30);
        shoppingList.Add("vejce", 50);
        shoppingList.Add("dortík", 100);

        // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není
        string item = "dortík";
        if (shoppingList.ContainsKey(item))
        {
            Console.WriteLine($"Cena za {item}: {shoppingList[item]},- Kč");
        }
        else
        {
            Console.WriteLine($"{item} není v seznamu nákupu.");
        }

       /* 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden 
       -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky */
        int quantityOfItem = 2; 

        if (shoppingList.ContainsKey(item))
        {
            shoppingList[item] = shoppingList[item] * quantityOfItem;

            Console.WriteLine($"Cena za {item} (počet kusů {quantityOfItem}): {shoppingList[item]},- Kč");
        }
        else
        {
            Console.WriteLine($"{item} není v seznamu nákupu.");
        }
    }
}
