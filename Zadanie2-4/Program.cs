internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoj wiek: ");
        int wiek = Convert.ToInt32(Console.ReadLine());
        Access(wiek);
    }

    static void Access(int wiek)
    {
        if (wiek >= 18)
        {
            Console.WriteLine("Access granted");
        }
        else if (wiek < 18 && wiek > 15)
        {
            Console.WriteLine("Do you have parental consent? (yes/no)");
            string zgoda = Console.ReadLine().ToLower();
            if (zgoda == "yes")
            {
                Console.WriteLine("Access granted");
            }
            else if (zgoda == "no")
            {
                Console.WriteLine("Access denied");
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }
        else
        {
            Console.WriteLine("Access denied");
        }
    }
}