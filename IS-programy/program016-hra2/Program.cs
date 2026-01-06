using System;

class StormAvoider
{
    static void Main()
    {
        int rows = 10; // počet řádků mapy
        int cols = 10; // počet sloupců mapy
        Random rand = new Random(); // generátor náhodných čísel

        // 1. Zadání startovní pozice
        Console.WriteLine("Zadej startovní pozici (např. a1 = levý horní roh):");
        (int startRow, int startCol) = ReadPosition(rows, cols);

        // 2. Zadání cílové pozice s kontrolou 
        int targetRow, targetCol;
        while (true)//nekonečná smyčka
        {
            Console.WriteLine("Zadej cílovou pozici (např. j10 = pravý dolní roh):");
            (targetRow, targetCol) = ReadPosition(rows, cols);

            if (targetRow == startRow && targetCol == startCol)
                Console.WriteLine("Cíl nemůže být stejný jako start! Zadej jinou pozici.");
            else //správné zadání cíle
                break; //vyskočení ze smyčky
        }

        // 3. Zadání počtu bouřek (1–20)
        int stormCount = 0;
        while (true)
        {
            Console.Write("Zadej počet bouřek (1–20): ");
            if (int.TryParse(Console.ReadLine(), out stormCount) && stormCount >= 1 && stormCount <= 20)//podmínka na počet
                break;
            Console.WriteLine("Neplatná hodnota. Zadej číslo mezi 1 a 20.");
        }

        // Inicializace pozice hráče
        int playerRow = startRow;
        int playerCol = startCol;

        // 4. Generování bouřek
        (int, int)[] storms = new (int, int)[stormCount];//pole dvojic, řadek sloupec
        for (int i = 0; i < stormCount; i++)
        {
            int r, c;
            do//generuj dokud není splněn počet a opakuj dokud je to špatně
            {
                r = rand.Next(0, rows);
                c = rand.Next(0, cols);
                // Kontrola: bouřka nesmí být na startu, cíli ani duplicita
            } while ((r == startRow && c == startCol) ||
                     (r == targetRow && c == targetCol) ||
                     StormExists(storms, i, r, c));
            storms[i] = (r, c);
        }

        // 5. Vypsání bouřek hráči na začátku
        Console.WriteLine("\nBouřky se nacházejí na souřadnicích:");
        foreach (var s in storms) //projdi celý seznam
            Console.WriteLine($"{(char)('a' + s.Item2)}{s.Item1 + 1}"); //sloupec a čislo na pismeno,  radek od nuly

        Console.WriteLine("\nHra začíná! Pohybuj se pomocí U/D/L/R (nahoru/dolů/levý/pravý)\n");

        bool gameOver = false; //přepínač stavu hry

        // 6. Hlavní herní smyčka
        while (!gameOver)
        {
            // Vykreslení mapy s hráčem a cílem
            DrawMap(rows, cols, playerRow, playerCol, targetRow, targetCol);

            // 6a. Čtení tahu od hráče
            Console.Write("Tvůj tah: ");
            string move = Console.ReadLine().Trim().ToUpper();//cekani na zapis, odstraneni mezer, velka pismena

            int newRow = playerRow;
            int newCol = playerCol;

            // 6b. Zpracování směru
            switch (move)//zadany text a rozhodni
            {
                case "U": newRow--; break;
                case "D": newRow++; break;
                case "L": newCol--; break;
                case "R": newCol++; break;
                default:
                    Console.WriteLine("Neplatný směr. Použij U, D, L nebo R.");
                    continue; // při špatném vstupu se smyčka opakuje
            }

            // 6c. Kontrola hranic mapy
            if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols)
            {
                Console.WriteLine("Nemůžeš jít mimo mapu!");
                continue;
            }

            playerRow = newRow;
            playerCol = newCol;

            // 6d. Kontrola, zda hráč nenarazil na bouřku
            bool hitStorm = false;
            for (int i = 0; i < stormCount; i++)
            {
                if (playerRow == storms[i].Item1 && playerCol == storms[i].Item2)
                {
                    hitStorm = true;
                    break;
                }
            }

            if (hitStorm)
            {
                DrawMap(rows, cols, playerRow, playerCol, targetRow, targetCol);
                Console.WriteLine("\n💥 Narazil jsi na bouřku! Hra skončila.");
                gameOver = true;
                continue;
            }

            // 6e. Kontrola, zda hráč dosáhl cíle
            if (playerRow == targetRow && playerCol == targetCol)
            {
                DrawMap(rows, cols, playerRow, playerCol, targetRow, targetCol);
                Console.WriteLine("\n✅ Gratuluji! Dostal jsi se do cílové pozice bezpečně.");
                gameOver = true;
            }
        }

        Console.WriteLine("\nStiskni libovolnou klávesu pro konec.");
        Console.ReadKey();
    }

    // Funkce kontroluje, zda bouřka již existuje v poli bouřek
    static bool StormExists((int, int)[] storms, int count, int r, int c)
    {
        for (int i = 0; i < count; i++)
            if (storms[i].Item1 == r && storms[i].Item2 == c) return true;
        return false;
    }

    // Funkce pro čtení pozice a1–j10 s kontrolou správného formátu
    static (int, int) ReadPosition(int rows, int cols)
    {
        while (true)
        {
            string input = Console.ReadLine().Trim().ToLower();
            if (input.Length >= 2)//kontrola delky vstupu
            {
                int col = input[0] - 'a'; // písmeno na sloupec
                if (!int.TryParse(input.Substring(1), out int row)) { Console.WriteLine("Neplatný řádek."); continue; }//vše za prvním znakem, kontrola jestli na číslo
                row -= 1; // převedení na index (0–9)
                if (row >= 0 && row < rows && col >= 0 && col < cols)
                    return (row, col);
            }
            Console.WriteLine("Neplatná souřadnice. Zadej například a1, b3, j10...");
        }
    }

    // Funkce pro vykreslení mapy
    static void DrawMap(int rows, int cols, int playerRow, int playerCol, int targetRow, int targetCol)
    {
        // Vykreslení osy X nahoře (a–j)
        Console.Write("   ");//odsazeni osy=radky
        for (int c = 0; c < cols; c++) //všechny sloupce
            Console.Write($"{(char)('a' + c)} "); //převod čísla sloupce na pismeno
        Console.WriteLine();

        // Vykreslení řádků s hráčem a cílem
        for (int r = 0; r < rows; r++)
        {
            Console.Write($"{r + 1,2} "); // osa Y vlevo, radky 1-10
            for (int c = 0; c < cols; c++)
            {
                if (r == playerRow && c == playerCol)
                {
                    // Letadlo ✈ zůstává
                    Console.Write("✈ ");
                }
                else if (r == targetRow && c == targetCol)
                {
                    // Cíl zeleně
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("X ");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(". ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
