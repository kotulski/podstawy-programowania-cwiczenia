internal class Program
{
    private static void Main(string[] args)
    {
        string text = "Sekwencja kwasów nukleinowych: 5-AATTGGCC-3";
        string substring = "5-AATTGGCC-3";
        int sbsindex = text.IndexOf(substring);
        string file = "biodata.txt";
        string currentDirectory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(currentDirectory, file);
        File.WriteAllText(filePath, text);

        using (var fileStream = new FileStream(file, FileMode.Open))
        {
            fileStream.Seek(sbsindex + 1, SeekOrigin.Begin);

            using (var reader = new StreamReader(fileStream))
            {
                string sequence = reader.ReadToEnd();
                Console.WriteLine(sequence);
            }
        }

        File.Delete(file);
    }

}