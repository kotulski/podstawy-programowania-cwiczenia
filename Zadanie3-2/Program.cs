internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podawaj liczby w zakresie od 0 do 10. Wpisz 5, aby zakończyć.");

        double sumaKwadratow = 0;
        double minimum = double.MaxValue;

        double liczba;

        while (true)
        {
            Console.Write("Podaj liczbę: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out liczba))
            {
                if (liczba >= 0 && liczba <= 10)
                {
                    sumaKwadratow += Math.Pow(liczba, 2);

                    if (liczba < minimum)
                    {
                        minimum = liczba;
                    }

                    if (liczba == 5)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Liczba powinna być w zakresie od 0 do 10. Spróbuj ponownie.");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy format liczby. Spróbuj ponownie.");
            }
        }

        Console.WriteLine($"Suma kwadratów podanych liczb: {sumaKwadratow}");
        Console.WriteLine($"Najmniejsza liczba: {minimum}");
    }
}