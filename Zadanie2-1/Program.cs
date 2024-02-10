internal class Program
{
    private static void Main(string[] args)
    {
        double a = 3.5;
        double b = 6;

        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine("Długość przeciwprostokątnej c wynosi: " + c);
    }
}