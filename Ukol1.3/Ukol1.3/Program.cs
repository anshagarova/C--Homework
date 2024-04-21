using System;

public class Lucistnik
{
    public int PocetSipu { get; private set; }

    public Lucistnik(int pocetSipu)
    {
        PocetSipu = pocetSipu;
    }

    public void Vystrel()
    {
        while (PocetSipu > 0)
        {
            Console.WriteLine("Vždy se trefím přímo do prostředí!");
            PocetSipu--;
        }
        if (PocetSipu <= 0)
        {
            Console.WriteLine("Nemám šípy.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Lucistnik lucistnik = new Lucistnik(5);
        while (lucistnik.PocetSipu > 0)
        {
            lucistnik.Vystrel();
        }
    }
}
