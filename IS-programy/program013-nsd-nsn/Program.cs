string again = "a";
while(again == "a") 
{
            
Console.Clear();
// to do vytvorit metodu

razítko ();


// nacitani hodnot
ulong a = nacticislo("zadejte cislo a:");
ulong b = nacticislo("zadejte cislo b:");

ulong nsd = vypocitatNSD(a, b);
ulong nsn = vypocitatNSN(a, b, nsd);

zobrazitvýsledky(a, b, nsd, nsn);


Console.WriteLine();
Console.WriteLine("=================");
Console.WriteLine("NSD cisel {0} a {1} je {2}", a, b, nsd);
Console.WriteLine("=================");
Console.WriteLine("NSN cisel {0} a {1} je {2}", a, b, nsn);
Console.WriteLine();
Console.WriteLine("pro opakování stiskněte a");

Console.WriteLine();
   Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();
 }
//metoda nevraci hodnotu
 static void razítko()
{
    
            Console.WriteLine("*******************************************");
            Console.WriteLine("*********** nsd nsn  ************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************* Simon Janousek *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

}

//metoda nacteni cisel
static ulong nacticislo(string zprava)
{

    Console.Write(zprava);
    ulong cislo;
      while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číselo znovu: ");
    }
    
    //metoda vrací konkretní datový typ
    return cislo;

    
}

/* metoda pro vypocet NSD dvou cisel */

static ulong vypocitatNSD (ulong a, ulong b){
    while (a != b){
        if(a > b)
        a = a - b;
        else
        b = b - a;
    }
return a;
}

/* metoda pro vypocet NSN na základě známé hodnoty NSD */
static ulong vypocitatNSN(ulong a, ulong b, ulong nsd)
{
  return (a*b)/nsd;
}

/*metoda zobrazit výsledky*/
static void zobrazitvýsledky(ulong a, ulong b, ulong nsd, ulong nsn){
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("=================");
Console.WriteLine("NSD cisel {0} a {1} je {2}", a, b, nsd);
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("=================");
Console.WriteLine("NSN cisel {0} a {1} je {2}", a, b, nsn);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.White;
}