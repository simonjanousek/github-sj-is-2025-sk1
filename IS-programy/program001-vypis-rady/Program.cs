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
    

    Console.WriteLine("Zadejte poslední číslo řady (celé číslo): ");
    int last;

    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("nezadali jste celé číslo, zadejte poslední číslo řady znovu: ");
    }
    
        Console.WriteLine("Zadejte diferenci (celé číslo): ");
    int step;

    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("nezadali jste celé číslo, zadejte diferenci znovu: ");
    }
    // výpis vstupních hodnot
    Console.WriteLine();
    Console.WriteLine("*****************************");
    Console.WriteLine("zadali jste tyto hodnoty");
    Console.WriteLine("první číslo řady: {0}", first);
    Console.WriteLine("poslední číslo řady: {0}", last);
    Console.WriteLine("diference: {0}", step);
    Console.WriteLine("**********************************************");
    Console.WriteLine("první číslo {0}; poslední číslo {1}; diference {2}" first, last, step);
    Console.WriteLine("**********************************************");
    Console.WriteLine();




    Console.WriteLine();
    Console.WriteLine("pro opakování stiskněte a");
    again = Console.ReadLine();

}