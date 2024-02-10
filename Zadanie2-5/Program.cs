internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj liczbę b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj liczbę c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        RownanieKwadratowe(a, b, c);
    }

    static void RownanieKwadratowe(double a, double b, double c)
    {
        // Wzór delty: ax^2 + bx + c = 0

        double delta = Math.Pow(b, 2) - 4 * a * c;
        delta = Math.Sqrt(delta);
        if (delta > 0)
        {
            double x1 = (-b - delta) / (2 * a);
            double x2 = (-b + delta) / (2 * a);
            x1 = (double)Math.Round(x1, 2);
            x2 = (double)Math.Round(x2, 2);
            Console.WriteLine($"X1 = {x1}    X2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            x = (double)Math.Round(x, 2);
            Console.WriteLine($"X = {x}");
        }
        else
        {
            Console.WriteLine("Równanie nie ma rozwiązań.");
        }
    }
}