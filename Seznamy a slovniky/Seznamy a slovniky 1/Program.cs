﻿using System;

class Program
{
    static void Main()
    {
        // 1. Vypiš aktuální datum a čas
        DateTime now = DateTime.Now;
        Console.WriteLine("Aktuální datum a čas: " + now);

        // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození
        DateTime dateOfBirth = new DateTime(1999, 11, 10);
        
        // Potom vypiš, kolik dnů od té doby uteklo.
        TimeSpan difference = now - dateOfBirth;
        int days = (int)difference.TotalDays;

        Console.WriteLine("Od tvého narození uplynulo " + days + " dnů.");
    }
}