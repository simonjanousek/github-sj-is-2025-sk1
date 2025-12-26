string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("************ Kombinovaná úloha ************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************* Šimon Janoušek **************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] numbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        numbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", numbs[i]);
    }

    // -----------------------------------------
    // Hledání max a min + všechny jejich pozice
    // -----------------------------------------
    int max = numbs[0];
    int min = numbs[0];
    for (int i = 1; i < n; i++)
    {
        if (numbs[i] > max)
            max = numbs[i];

        if (numbs[i] < min)
            min = numbs[i]; 
    }

    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    Console.Write($"Maximum je {max}; jeho pozice: ");
    for (int i = 0; i < n; i++) {
        if (numbs[i] == max)
            Console.Write($"{i}; ");
    }
    Console.WriteLine();
    Console.WriteLine("---------------------------------------");
    Console.Write($"Minimum je {min}; jeho pozice: ");
    for (int i = 0; i < n; i++) {
        if (numbs[i] == min)
            Console.Write($"{i}; ");
    }

    // -----------------------------------------
    // Seřazení pole - Bubble sort (s optimalizací)
    // -----------------------------------------
    int swaps = 0;
    for (int i = 0; i < n - 1; i++)
    {
        bool swapped = false;
        for (int j = 0; j < n - i - 1; j++)
        {
            if (numbs[j] > numbs[j + 1])
            {
                int tmp = numbs[j + 1];
                numbs[j + 1] = numbs[j];
                numbs[j] = tmp;
                swaps++;
                swapped = true;
            }
        }

        if (!swapped)
            break; // pole je již seřazené
    }

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Seřazené čísla:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", numbs[i]);
    }
    Console.WriteLine();
    Console.WriteLine($"Počet prohozů (swaps): {swaps}");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}