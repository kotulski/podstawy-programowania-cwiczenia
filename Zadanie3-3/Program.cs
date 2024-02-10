internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        do
        {
            double kwadrat = (Math.Pow(i, 2));

            Console.WriteLine("Kwadrat liczby i wynosi: " + kwadrat);
            i++;
        } while (i <= 20);
    }
}