internal class Program
{
    static double plnToUsd = 0.25;
    static double usdToEur = 0.92;
    static double usdToChf = 0.8;
    static double usdToGbp = 0.79;
    private static void Main(string[] args)
    {
        Console.WriteLine("Podaj kwotę w PLN, którą chcesz przewalutować: ");
        double pln = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wybierz walutę docelową:\nEUR - Euro\nCHF - Frank Szwajcarski\nGBP - Funt Brytyjski");
        string currency = Console.ReadLine().ToUpper();
        Console.WriteLine($"Kwota w {currency} po przewalutowaniu wynosi {AmountAfterExchange(AmountInUSD(pln), currency)}.");
    }

    public static double AmountInUSD(double pln)
    {
        double usd = pln * plnToUsd;
        return usd;
    }

    static double AmountAfterExchange(double usd, string currency)
    {
        if (currency == "EUR")
        {
            double exchange = usd * usdToEur;
            return exchange;
        }
        else if (currency == "CHF")
        {
            double exchange = usd * usdToChf;
            return exchange;
        }
        else if (currency == "GBP")
        {
            double exchange = usd * usdToGbp;
            return exchange;
        }
        else
        {
            throw new Exception("Nieprawidłowa waluta.");
        }
    }
}