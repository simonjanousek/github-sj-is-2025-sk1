string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************");
    Console.WriteLine("********* max, min ************");
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
    for (int i = 0; i < n; i++)
    {

        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ", myRandNumbs[i]);

    }

    //hledání maxima a minima a jejich prvních pozic

    int max = myRandNumbs[0]; //předpokládáme že první prvek v poli je maximem
    int min = myRandNumbs[0]; //předpokládáme že první prvek je minimem
    int posMax = 0;
    int posMin = 0;
    for (int i = 1; 1 < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }


   

    Console.WriteLine();
    Console.WriteLine("==========================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("=========================================");
    Console.WriteLine();

    //vykreslení přesípacích hodin

    if (max >= 3)
    {
    
     for (int i = 0; i < max; i++)

        {
            int spaces, stars;
            if (i < max / 2)
            {
                spaces = i;
                //horní polovina - s každým dalším řádkem ubývají dvě hvězdičky (jedna z každé strany)
                stars = max - 2 * i;
            }

            else
            {
                spaces = max - i - 1;
                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + i;
                }
                else
                {
                    stars = stars = 2 * (i - max / 2) + 2;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;

            for (int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }

            for (int st = 0; st < stars; st++)
                Console.Write("*");

            Console.WriteLine();
            Console.ResetColor();

        
       
}

    }
    else
    {
        Console.WriteLine("maximum menší než 3, obrazec se nevykreslí");

    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}

