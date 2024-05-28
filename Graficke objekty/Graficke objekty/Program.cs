using System;
using System.Collections.Generic;

class GrafickyObjekt
{
    public virtual void Vykreslit()
    {
        Console.WriteLine("X");
    }
}

class Obdelnik : GrafickyObjekt
{
    public override void Vykreslit()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("##############");
        Console.WriteLine("#            #");
        Console.WriteLine("##############");
        Console.ResetColor();
    }
}

class Trojuhelnik : GrafickyObjekt
{
    public override void Vykreslit()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("      #");
        Console.WriteLine("     ###");
        Console.WriteLine("    #####");
        Console.WriteLine("   #######");
        Console.WriteLine("  #########");
        Console.WriteLine(" ############");
        Console.ResetColor();
    }
}

class Text : GrafickyObjekt
{
    public string TextValue { get; set; } = ""; 

    public override void Vykreslit()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(TextValue);
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<GrafickyObjekt> seznamObjektu = new List<GrafickyObjekt>();

        seznamObjektu.Add(new Obdelnik());
        seznamObjektu.Add(new Trojuhelnik());

        Text textObjekt = new Text();
        textObjekt.TextValue = "Tento text se vypíše na konzoli";
        seznamObjektu.Add(textObjekt);

        foreach (var objekt in seznamObjektu)
        {
            objekt.Vykreslit();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
