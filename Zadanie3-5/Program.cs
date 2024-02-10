internal class Program
{
    private static void Main(string[] args)
    {
        // Wzór - bok kwadratu * liczba kropek w kole / liczba kropek w kwadracie
        // Promień koła - r
        // Bok kwadratu - 2r
        int start = Environment.TickCount;
        double squarePoints = new Random().Next();
        double circlePoints = new Random().Next((int)squarePoints);
        double r = circlePoints / squarePoints;
        double pi = 4.0 * r;
        Console.WriteLine($"Liczba pi w wynosi: {pi}");
        int stop = Environment.TickCount;
        int time = stop - start;
        Console.WriteLine($"Czas obliczeń sekwencyjnych: {time} milisekund.");
    }
}