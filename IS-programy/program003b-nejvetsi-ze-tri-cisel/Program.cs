string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("***** porovnání tří čísel *****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Šimon Janoušek ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte hodnotu (celé číslo) - hodnota A: ");
    int a;

    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu A znovu: ");
    }

    Console.Write("Zadejte hodnotu (celé číslo) - hodnota B: ");
    int b;

    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu B znovu: ");
    }

    Console.Write("Zadejte hodnotu (celé číslo) - hodnota C: ");
    int c;

    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu C znovu: ");
    }
    if (a > b){

        if (a > c)
            Console.WriteLine($"největší číslo je A = {a}");
        else
           Console.WriteLine($"největší číslo je C = {c}"); 
        }
    else
    {

        if (b > c)
            Console.WriteLine($"největší číslo je B = {b}");
        else
          Console.WriteLine($"největší číslo je C = {C}");

    }
    }

    Console.WriteLine("***************************");


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}