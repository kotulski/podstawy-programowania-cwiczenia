internal class Program
{
    private static void Main(string[] args)
    {
        int w = 10;
        int h = 10;
        int[,] numbers = new int[w, h];
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                numbers[i, j] = 1;
            }
        }

        string file = "dane.txt";
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, file);
        File.WriteAllText(filePath, Convert(numbers));

        try
        {
            using (var fileStream = new FileStream(file, FileMode.Open))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    string rNumbers = reader.ReadToEnd();
                    Console.WriteLine(rNumbers);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Plik nie istnieje. Nie udało się odczytać tablicy.");
        }

    }

    static string Convert(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        string arrayAsString = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arrayAsString += array[i, j].ToString() + " ";
            }
            arrayAsString += Environment.NewLine;
        }

        return arrayAsString;
    }
}