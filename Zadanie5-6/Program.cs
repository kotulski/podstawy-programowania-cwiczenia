internal class Program
{
    private static void Main(string[] args)
    {
        int[] fibonacci = new int[10];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        for (int x = 2; x < 10; x++)
        {
            fibonacci[x] = fibonacci[x - 1] + fibonacci[x - 2];
        }
        foreach (int i in fibonacci)
        {
            Console.WriteLine(i);
        }
    }
}