internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj swój wzrost w metrach: ");
        double wzrost = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj swoją wagę w kilogramach: ");
        double waga = double.Parse(Console.ReadLine());

        double bmi = waga / Math.Pow(wzrost, 2);

        Console.WriteLine("Twój wskaźnik BMI wynosi: " + bmi);

        Console.WriteLine("Wynik ten oznacza: ");
        if (bmi < 18.5)
            Console.WriteLine("niedowagę");
        else if (bmi < 24.9)
            Console.WriteLine("prawidłową wagę");
        else if (bmi < 29.9)
            Console.WriteLine("nadwagę");
        else
            Console.WriteLine("otyłość");
    }
}