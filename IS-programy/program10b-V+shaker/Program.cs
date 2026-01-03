
        Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
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
        while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound <= lowerBound)
        {
            Console.Write("Horní mez musí být větší než dolní. Zadejte znovu horní mez: ");
        }

        Console.WriteLine();
        Console.WriteLine("================================================");
        Console.WriteLine("Zadané hodnoty:");
        Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
        Console.WriteLine("================================================");

        // Deklarace pole
        int[] numbs = new int[n];
        Random rand = new Random();

        Console.WriteLine();
        Console.WriteLine("Pseudonáhodná čísla:");
        for (int i = 0; i < n; i++)
        {
            numbs[i] = rand.Next(lowerBound, upperBound + 1);
            Console.Write(numbs[i] + "; ");
        }

        // SHAKER SORT
        int left = 0;
        int right = n - 1;

        while (left < right)
        {
            for (int i = left; i < right; i++)
            {
                if (numbs[i] > numbs[i + 1])
                {
                    int tmp = numbs[i];
                    numbs[i] = numbs[i + 1];
                    numbs[i + 1] = tmp;
                }
            }
            right--;

            for (int i = right; i > left; i--)
            {
                if (numbs[i] < numbs[i - 1])
                {
                    int tmp = numbs[i];
                    numbs[i] = numbs[i - 1];
                    numbs[i - 1] = tmp;
                }
            }
            left++;
        }

        Console.WriteLine("\nSeřazená čísla:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbs[i] + "; ");
        }

        // MEDIÁN
        int median;
        if (n % 2 == 1)
        {
            median = numbs[n / 2];
        }
        else
        {
            median = (int)((numbs[n / 2 - 1] + numbs[n / 2]) / 2.0);
        }

        if (median < 2)
            median = 2;

        Console.WriteLine($"\n\nMedián = {median}");

        // VYKRESLENÍ OBRAZCE V
        Console.WriteLine("\nObrazec V:");
        int sirka = 2 * median - 1;

        for (int i = 0; i < median; i++)
        {
            for (int j = 0; j < sirka; j++)
            {
                if (j == i || j == sirka - i - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }


