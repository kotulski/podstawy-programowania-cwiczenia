internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Wartości funkcji y = root(3^2) * x dla x w przedziale od 0 do 10:");

        for (int x = 0; x <= 10; x++)
        {
            double y = Math.Sqrt(Math.Pow(3, 2)) * x;
            Console.WriteLine($"x = {x}, y = {y}");
        }
    }
}
