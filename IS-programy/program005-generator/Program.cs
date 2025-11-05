string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("***** pseudonáhodná čísla  ****");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Šimon Janoušek ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }
    Console.WriteLine();

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }
    Console.WriteLine();

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }
    Console.WriteLine();

    Console.WriteLine("*************************");
    Console.WriteLine("zadané hodnoty:");
    Console.WriteLine("počet čísel: {0}; dolní mez {1}; horní mez {2}", n, lowerBound, upperBound);
    Console.WriteLine("*************************");


 int[] myRandNumbs = new int[n];

    //deklarace pole


    Random myRandNumb = new Random();
    Console.WriteLine();
    Console.WriteLine("************************************");
    Console.WriteLine("pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {

        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
        
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}

