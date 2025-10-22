string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("********** Součet Cifer **********");
    Console.WriteLine("************************");
    Console.WriteLine("************ SJ *************");
    Console.WriteLine("*********************");
    Console.WriteLine();



 

    //Vstup hodnoty do programu 
    Console.WriteLine("Zadejte číslo pro nějž chcete určit součet a součin cifer (celé číslo): ");
    int number;

 

 

 

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("nezadali jste celé číslo, zadejte číslo pro nějž chcete určit znovu: ");
    }


    int suma = 0;
    int = numberBackup = number;
    int = Digit;

    if (number < 0) {
        number = -number;
    }
    while (number >= 10) {
        digit = number % 10; //zbytek po dělení 10 budou určovat cifry
        number = (number - digit) / 10;
        Console.WriteLine("digit = {0}", digit);
        suma = suma + digit;

    }
    Console.WriteLine("zbytek = {0}", number);

    // nesmíme zapomenout přičíst poslední číslici do sumy
    suma = suma + number;

    Console.WriteLine();
Console.WriteLine("součet cifer čísal {0} je {1}",numberBackup, suma)

    Console.WriteLine();
    Console.WriteLine("pro opakování stiskněte a");
    again = Console.ReadLine();
}