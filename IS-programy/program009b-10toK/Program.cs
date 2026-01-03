string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** 10 -> libovolná *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Šimon Janoušek******");
    Console.WriteLine("****************************");
    Console.WriteLine();

    Console.Write("Zadejte číslo v desítkové soustavě: ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
    }

    Console.Write("Zadejte cílovou soustavu (2–16): ");
    uint zaklad;
    while (!uint.TryParse(Console.ReadLine(), out zaklad) || zaklad < 2 || zaklad > 16)
    {
        Console.Write("Zadejte soustavu v rozsahu 2–16: ");
    }

    uint backupNumber10 = number10;
    uint[] myArray = new uint[32];
    uint i = 0;

    while (number10 > 0)
    {
        myArray[i] = number10 % zaklad;
        number10 = number10 / zaklad;

        i++;
    }

    Console.WriteLine();
    Console.Write("Výsledek: ");

    for (int j = (int)i - 1; j >= 0; j--)
    {
        if (myArray[j] < 10)
            Console.Write(myArray[j]);
        else
            Console.Write((char)('A' + myArray[j] - 10));
    }

    Console.WriteLine();
    Console.WriteLine("\nPro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
