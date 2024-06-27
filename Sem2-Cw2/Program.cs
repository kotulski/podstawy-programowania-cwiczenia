using System;

namespace NumberSorting
{
    class Sorting
    {
        private double[] numbers;

        public void Read_Data()
        {
            numbers = new double[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Wpisz liczbę {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void Process_Data()
        {
            Array.Sort(numbers);
        }

        public void Show_Results()
        {
            Console.WriteLine("Liczby posortowane:");
            foreach (double number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sorting sorting = new Sorting();
            sorting.Read_Data();
            sorting.Process_Data();
            sorting.Show_Results();
        }
    }
}