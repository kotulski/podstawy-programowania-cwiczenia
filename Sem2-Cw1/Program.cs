using System;

namespace RectangleAreaCalculator
{
    class Rectangle
    {
        private double a;
        private double b;
        private double surfaceArea;

        public void Read_Data()
        {
            Console.Write("Podaj długość boku a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj długość boku b: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public void Process_Data()
        {
            surfaceArea = a * b;
        }

        public void Show_Results()
        {
            Console.WriteLine($"Bok a: {a:F2}");
            Console.WriteLine($"Bok b: {b:F2}");
            Console.WriteLine($"Pole powierzchni: {surfaceArea:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Read_Data();
            rectangle.Process_Data();
            rectangle.Show_Results();
        }
    }
}