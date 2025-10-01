string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("********** Výpis řady **********");
    Console.WriteLine("************************");
    Console.WriteLine("************ SJ *************");
    Console.WriteLine("*********************");
    Console.WriteLine();


    //Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.WriteLine("Zadejte první číslo řady (celé číslo): ");
    int first;

    while (!int.TryParse(Console.ReadLine(), out first)) 
    {
        Console.WriteLine("nezadali jste celé číslo, zadejte první číslo řady znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine("pro opakování stiskněte a");
    again = Console.ReadLine();

}