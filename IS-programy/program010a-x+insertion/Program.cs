
        Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n < 3)
        {
            Console.Write("Zadejte celé číslo >= 3: ");
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
            Console.Write("Horní mez musí být větší než dolní. Zadejte znovu: ");
        }

        // Deklarace pole
        int[] numbs = new int[n];
        Random rand = new Random();

        Console.WriteLine("\nPseudonáhodná čísla:");
        for (int i = 0; i < n; i++)
        {
            numbs[i] = rand.Next(lowerBound, upperBound + 1);
            Console.Write(numbs[i] + "; ");
        }

        // INSERTION SORT (vzestupně)
        for (int i = 1; i < n; i++)
        {
            int current = numbs[i];
            int j = i - 1;

            while (j >= 0 && numbs[j] > current)
            {
                numbs[j + 1] = numbs[j];
                j--;
            }
            numbs[j + 1] = current;
        }

        Console.WriteLine("\n\nSeřazené pole (insertion sort):");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbs[i] + "; ");
        }

        // vyska 3. nejvyssi cislo
        int vyska = numbs[n - 3];

        // sirka = prumer hodnot v poli
        int soucet = 0;
        for (int i = 0; i < n; i++)
        {
            soucet += numbs[i];
        }
        int sirka = soucet / n;

        // X
        int velikost = Math.Min(vyska, sirka);

        Console.WriteLine("\n\nVykreslený obrazec X:");
        Console.WriteLine("Výška = {0}, Šířka = {1}, Použitá velikost = {2}", vyska, sirka, velikost);
        Console.WriteLine();

        for (int i = 0; i < velikost; i++)
        {
            for (int j = 0; j < velikost; j++)
            {
                if (j == i || j == velikost - i - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
