string again = "a";
Random rnd = new Random();

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("********** extrémy ************");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Šimon Janoušek ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Nezadali jste celé číslo. Zkuste to znovu: ");

    Console.Write("Zadejte dolní mez: ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
        Console.Write("Nezadali jste celé číslo. Zkuste to znovu: ");

    Console.Write("Zadejte horní mez: ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
        Console.Write("Nezadali jste celé číslo. Zkuste to znovu: ");

    Console.WriteLine();

    // Vytvoření pole
    int[] numbs = new int[n];

    // Generování náhodných čísel
    for (int i = 0; i < n; i++)
        numbs[i] = rnd.Next(lowerBound, upperBound + 1);

    // Výpočet extrémů
    int max = numbs[0];
    int min = numbs[0];

    for (int i = 1; i < n; i++)
    {
        if (numbs[i] > max) max = numbs[i];
        if (numbs[i] < min) min = numbs[i];
    }
    {
    Console.WriteLine("*******************");
    Console.WriteLine("Max: {0}", max);
    Console.WriteLine("Min: {0}", min);
    Console.WriteLine("*******************");
 }
    Console.WriteLine("Pro opakování programu stiskněte a:");
    again = Console.ReadLine();
}

/*pozice*/
 Console.WriteLine();
    Console.WriteLine("**************");
    Console.WriteLine($"maximum je {max}; jeho pozice: ");
    for (int i = 1; i < n; i++)
{
    if (numbs[i] == max)
    console.Write($"{i}: ");
}

 Console.WriteLine();
    Console.WriteLine("**************");
    Console.WriteLine($"minimum je {min}; jeho pozice: ");
    for (int i = 0; i < n; i++)
{
    if (numbs[i] == min)
    console.Write($"{i}: ");
}

/* serazeni pole*/