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
 

int size = 7;
int diag = size; // sloupec, kde se má tisknout hvězda

for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= size; j++)
    {
        if (i == 1 || i == size || j == diag)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    diag--; // posune diagonálu doleva pro další řádek
    Console.WriteLine();
}


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
