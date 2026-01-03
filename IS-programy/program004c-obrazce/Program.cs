string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("***** M, N , N (zrcadlově) ****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Šimon Janoušek ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    
Console.Write("zadejte šířku: ");
int sirka;
while (!int.TryParse(Console.ReadLine(), out sirka))
{
    Console.Write("nezadali jste celé číslo: ");
}

Console.Write("zadejte výšku: ");
int vyska;
while (!int.TryParse(Console.ReadLine(), out vyska))
{
    Console.Write("nezadali jste celé číslo: ");
}

Console.WriteLine("\nPísmeno Z:\n");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (i == 0 || i == vyska - 1 || j == sirka - i - 1)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nPísmeno N:\n");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j == 0 || j == sirka - 1 || j == i)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nPísmeno N s opačnou diagonálou:\n");
for (int i = 0; i < vyska; i++)
{
    for (int j = 0; j < sirka; j++)
    {
        if (j == 0 || j == sirka - 1 || j == sirka - i - 1)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
