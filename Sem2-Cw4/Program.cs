using System;
using System.Collections.Generic;

public abstract class Device
{
    public string Name { get; set; }
    public string Brand { get; set; }

    public Device(string name, string brand)
    {
        Name = name;
        Brand = brand;
    }

    public abstract string DeviceInfo();
    public abstract string PerformOperation();
}

public class Computer : Device
{
    public string Cpu { get; set; }

    public Computer(string name, string brand, string cpu)
        : base(name, brand)
    {
        Cpu = cpu;
    }

    public override string DeviceInfo()
    {
        return $"Komputer: {Name}, Marka: {Brand}, Procesor: {Cpu}";
    }

    public override string PerformOperation()
    {
        return $"{Name} wykonuje obliczenia.";
    }
}

public class Printer : Device
{
    public int InkLevel { get; set; }

    public Printer(string name, string brand, int inkLevel)
        : base(name, brand)
    {
        InkLevel = inkLevel;
    }

    public override string DeviceInfo()
    {
        return $"Drukarka: {Name}, Marka: {Brand}, Poziom tuszu: {InkLevel}%";
    }

    public override string PerformOperation()
    {
        return $"{Name} drukuje dokumenty.";
    }
}

public class Router : Device
{
    public int Speed { get; set; }

    public Router(string name, string brand, int speed)
        : base(name, brand)
    {
        Speed = speed;
    }

    public override string DeviceInfo()
    {
        return $"Router: {Name}, Marka: {Brand}, Prędkość: {Speed} Mbps";
    }

    public override string PerformOperation()
    {
        return $"{Name} routuje ruch internetowy.";
    }
}

public class Program
{
    public static void Main()
    {
        List<Device> devices = new List<Device>
        {
            new Computer("PatrykPC", "Lenovo", "Intel i5 13 gen"),
            new Printer("Printer", "HP", 100),
            new Router("Router domowy", "TP-Link", 400)
        };

        foreach (var device in devices)
        {
            Console.WriteLine(device.DeviceInfo());
            Console.WriteLine(device.PerformOperation());
        }
    }
}