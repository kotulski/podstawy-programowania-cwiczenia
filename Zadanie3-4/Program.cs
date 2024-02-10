internal class Program
{
    private static void Main(string[] args)
    {
        string[] pets = { "cat", "dog", "parrot", "guinea pig" };
        foreach (string pet in pets)
        {
            Console.WriteLine(pet);
            if (pet == "dog")
            {
                Console.WriteLine("End");
                break;
            }
        }
    }
}