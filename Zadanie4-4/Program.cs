using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList wszystkieMiasta = new ArrayList();
        wszystkieMiasta.Add("Gdańsk");
        wszystkieMiasta.Add("Warszawa");
        wszystkieMiasta.Add("Katowice");
        wszystkieMiasta.Add("Poznań");
        wszystkieMiasta.Add("Kraków");
        wszystkieMiasta.Add("Rzeszów");
        wszystkieMiasta.Sort();
        foreach (string miasto in wszystkieMiasta)
        {
            Console.WriteLine(miasto);
        }
    }
}