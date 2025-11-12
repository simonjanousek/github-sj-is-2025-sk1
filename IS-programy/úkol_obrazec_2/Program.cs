   {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*******************************");
            Console.WriteLine("************* N  **************");
            Console.WriteLine("*******************************");
            Console.WriteLine("******* Šimon Janoušek ********");
            Console.WriteLine("*******************************");
            Console.WriteLine();

            Console.Write("Zadejte velikost (celé číslo): ");

            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.WriteLine();

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (j == 1 || j == size || j == i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
            again = Console.ReadLine().ToLower();
        }
    }

