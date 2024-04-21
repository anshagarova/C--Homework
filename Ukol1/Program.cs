using System;

public class Program
{
	public static void Main()
	{
		do
		{
		//Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.
		Console.WriteLine("Zadej první číslo");
		string vstup1 = Console.ReadLine();
		double prvniCislo;
		
		while (!double.TryParse(vstup1, out prvniCislo))
        {
            Console.WriteLine("Neplatný vstup. Zadej prosím platné číslo.");
            vstup1 = Console.ReadLine();
        }

		Console.WriteLine("Zadej druhé číslo");
		string vstup2 = Console.ReadLine();
		double druheCislo;
		
		while (!double.TryParse(vstup2, out druheCislo))
        {
            Console.WriteLine("Neplatný vstup. Zadej prosím platné číslo.");
            vstup2 = Console.ReadLine();
        }
		
		double soucet = prvniCislo + druheCislo;
		
        Console.WriteLine("Součet je {0}", soucet);
		Console.WriteLine("Chcete pokračovat?");
    }
	while(Console.ReadLine().ToLower() == "ano");
  }

}