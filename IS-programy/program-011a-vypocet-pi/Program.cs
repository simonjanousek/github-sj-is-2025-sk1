string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** vypocet pi *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Simon Janousek ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
class Program
{
    static void Main()
    {
        Console.Write("Zadej požadovanou přesnost (např. 0.000001): ");
        if (!double.TryParse(Console.ReadLine(), out double precision) || precision <= 0)
        {
            Console.WriteLine("Neplatná přesnost.");
            return;
        }

        double pi = 0.0;
        double prevPi;
        double k = 0;
        double sign = 1.0;

        while (true)
        {
            prevPi = pi;

            double term = 1.0 / (2.0 * k + 1.0); // 1/1, 1/3, 1/5...
            pi += sign * term;
            sign = -sign;

            double approxPi = pi * 4.0;

            if (Math.Abs(approxPi - prevPi * 4.0) < precision)
            {
                Console.WriteLine($"Výsledek: {approxPi}");
                Console.WriteLine($"Počet členů: {k + 1}");
                break;
            }

            k++;
        }
    }
}




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}
