internal class Program
{
    private static void Main(string[] args)
    {
        int[] tablica1 = new int[15];
        Random rand = new Random();
        for (int i = 0; i < tablica1.Length; i++)
        {
            tablica1[i] = rand.Next(0, 10);
        }
        foreach (int i in tablica1)
        {
            Console.Write(i + " ");
        }
    }
}