string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("***** obdelník  ***************");
    Console.WriteLine("*******************************");
    Console.WriteLine("******* Šimon Janoušek ********");
    Console.WriteLine("*******************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte šířku (celé číslo): ");
    int width;

    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku znovu: ");
    }


    Console.Write("Zadejte výšku (celé číslo): ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku znovu: ");
    }

    
    for (int i=1; i<= height ; i++)
    {
        for(int j=1; j <= width; j++)
        {
            Console.Write("*");
            
            }
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}
