using System;
﻿using System.Numerics;

string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("*** Ciferný součet a součin ***");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Šimon Janoušek ********");
    Console.WriteLine("*******************************");



    // Načtení čísla od uživatele
    Console.Write("Zadejte celé číslo: ");
    // Vstup hodnoty do programu
    Console.Write("Zadejte celé číslo, pro které chcete spočítat součet a součin cifer: ");
    int number;

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    int original = number;
    if (number < 0) number = -number; // práce s kladnou hodnotou

    int suma = 0;
    int soucet = 0;
    int soucin = 1;
    int zalohaCisla = number;
    int cifra; // proměnná pro jednotlivé cifry čísla

    // záporné na kladné
    if (number < 0)
    {
        number = -number;
    }

    // Výpočet součtu a součinu číslic
    while (number > 0)
    while (number >= 10)
    {
        int cifra = number % 10;
        suma += cifra;
        cifra = number % 10;
        number = (number - cifra) / 10;
        Console.WriteLine("Cifra = {0}", cifra);
        soucet += cifra;
        soucin *= cifra;
        number /= 10;
    }

    // zpracování poslední cifry
    Console.WriteLine("Cifra = {0}", number);
    soucet += number;
    soucin *= number;

    Console.WriteLine();
    Console.WriteLine($"Součet cifer čísla {original} je: {suma}");
    Console.WriteLine($"Součin cifer čísla {original} je: {soucin}");
    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", zalohaCisla, soucet);
    Console.WriteLine("Součin cifer čísla {0} je {1}", zalohaCisla, soucin);

    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");

    again = Console.ReadLine();

}
