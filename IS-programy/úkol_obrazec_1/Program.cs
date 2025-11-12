string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("************* Z  **************");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Šimon Janoušek ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně

 Console.Write("Zadejte velikost (celé číslo): ");

int size;
 while (!int.TryParse(Console.ReadLine(), out size))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }
    Console.WriteLine();

int diag = size; // diagonála vysoká jako šířka

for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= size; j++)
    {
        if (i == 1 || i == size || j == diag)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    diag--; // posunutí diag doleva na další řádek o  jedna
    Console.WriteLine();
}


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
