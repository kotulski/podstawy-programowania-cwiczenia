using System;
public interface IVehicle
{
    string Make { get; set; }
    string Model { get; set; }
    int Year { get; set; }

    void Start();
    void Stop();
}

public class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int numberOfDoors)
    {
        Make = make;
        Model = model;
        Year = year;
        NumberOfDoors = numberOfDoors;
    }

    public void Start()
    {
        Console.WriteLine($"Samochód {Make} {Model} został uruchomiony.");
    }

    public void Stop()
    {
        Console.WriteLine($"Samochód {Make} {Model} został zatrzymany.");
    }
}

public class Bus : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int PassengerCapacity { get; set; }

    public Bus(string make, string model, int year, int passengerCapacity)
    {
        Make = make;
        Model = model;
        Year = year;
        PassengerCapacity = passengerCapacity;
    }

    public void Start()
    {
        Console.WriteLine($"Autobus {Make} {Model} został uruchomiony.");
    }

    public void Stop()
    {
        Console.WriteLine($"Autobus {Make} {Model} został zatrzymany.");
    }
}

public class Program
{
    public static void Main()
    {
        IVehicle car = new Car("Toyota", "Prius", 2015, 5);
        IVehicle bus = new Bus("Solaris", "Urbino", 2012, 62);

        car.Start();
        car.Stop();

        bus.Start();
        bus.Stop();

        Car specificCar = car as Car;
        if (specificCar != null)
        {
            Console.WriteLine($"Liczba drzwi w samochodzie: {specificCar.NumberOfDoors}");
        }

        Bus specificBus = bus as Bus;
        if (specificBus != null)
        {
            Console.WriteLine($"Pojemność pasażerów w autobusie: {specificBus.PassengerCapacity}");
        }
    }
}