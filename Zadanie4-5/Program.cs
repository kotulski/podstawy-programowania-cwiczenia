internal class Program
{
    private static void Main(string[] args)
    {
        int w = 10;
        int h = 10;
        int[,] a = new int[w, h];
        int[,] b = new int[w, h];
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                a[i, j] = 1;
                b[i, j] = 2;
            }
        }

        WypiszTablice(DodajTablice(a, b));
    }
    static void WypiszTablice(int[,] tablica)
    {
        for (int y = 0; y < tablica.GetLength(1); y++)
        {
            for (int x = 0; x < tablica.GetLength(0); x++)
                Console.Write("{0} ", tablica[x, y]);
            Console.WriteLine();
        }
    }

    static int[,] DodajTablice(int[,] tablica1, int[,] tablica2)
    {
        int[,] tablica3 = new int[tablica1.GetLength(0), tablica1.GetLength(1)];
        for (int y = 0; y < tablica1.GetLength(1); y++)
        {
            for (int x = 0; x < tablica1.GetLength(0); x++)
                tablica3[x, y] = tablica1[x, y] + tablica2[x, y];
        }
        return tablica3;
    }
}