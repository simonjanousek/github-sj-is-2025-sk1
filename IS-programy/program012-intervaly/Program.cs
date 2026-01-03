
        string again = "a";

        while (again.ToLower() == "a")
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("***** Intervaly *****");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************* Simon Janousek *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            // Zadání počtu čísel
            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
            }

            // Dolní mez
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while (!int.TryParse(Console.ReadLine(), out dm))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            // Horní mez
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while (!int.TryParse(Console.ReadLine(), out hm) || hm <= dm)
            {
                Console.Write("Horní mez musí být větší než dolní. Zadejte znovu: ");
            }

            // Počet intervalů
            Console.Write("Zadejte počet intervalů: ");
            int pocetIntervalu;
            while (!int.TryParse(Console.ReadLine(), out pocetIntervalu) || pocetIntervalu < 1)
            {
                Console.Write("Počet intervalů musí být celé číslo >= 1. Zadejte znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine($"Počet čísel: {n}; Dolní mez: {dm}; Horní mez: {hm}; Počet intervalů: {pocetIntervalu}");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // Generování náhodných čísel
            int[] myArray = new int[n];
            Random randomNumber = new Random();

            Console.WriteLine("\nNáhodná čísla:");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write($"{myArray[i]}; ");
            }

            // Vypočítáme šířku každého intervalu
            double intervalSize = (double)(hm - dm + 1) / pocetIntervalu;

            // Počítadla pro každý interval
            int[] intervaly = new int[pocetIntervalu];

            // Rozřazení čísel do intervalů
            for (int i = 0; i < n; i++)
            {
                int index = (int)((myArray[i] - dm) / intervalSize);
                if (index >= pocetIntervalu) index = pocetIntervalu - 1; // hrana
                intervaly[index]++;
            }

            // Výpis intervalů
            Console.WriteLine("\nPočet čísel v jednotlivých intervalech:");
            for (int i = 0; i < pocetIntervalu; i++)
            {
                double start = dm + i * intervalSize;
                double end = start + intervalSize - 1;
                if (i == pocetIntervalu - 1) end = hm; // poslední interval
                Console.WriteLine($"Interval <{start:F2}, {end:F2}>: {intervaly[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
        }
