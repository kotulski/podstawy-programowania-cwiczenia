using System;

namespace EmployeeManagement
{
    class Employee
    {
        protected string name;
        protected string lastname;
        protected string street;
        protected string city;

        public void Read()
        {
            Console.Write("Podaj imię: ");
            name = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            lastname = Console.ReadLine();

            Console.Write("Podaj ulicę: ");
            street = Console.ReadLine();

            Console.Write("Podaj miasto: ");
            city = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Nazwisko: {lastname}");
            Console.WriteLine($"Ulica: {street}");
            Console.WriteLine($"Miasto: {city}");
        }
    }

    class HR : Employee
    {
        private string education;
        private string businessrole;

        public void Read1()
        {
            Read();

            Console.Write("Podaj wykształcenie: ");
            education = Console.ReadLine();

            Console.Write("Podaj rolę biznesową: ");
            businessrole = Console.ReadLine();
        }

        public void Show1()
        {
            Show();

            Console.WriteLine($"Wykształcenie: {education}");
            Console.WriteLine($"Rola biznesowa: {businessrole}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HR hrEmployee = new HR();
            hrEmployee.Read1();
            hrEmployee.Show1();
        }
    }
}