using System;

public class Vehicle
{
    private string model;
    private double price;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
                price = value;
            else
                price = 0; // or throw an exception if you want
        }
    }

    public Vehicle(string model, double price)
    {
        Model = model;
        Price = price;
    }

    public virtual double GetTax()
    {
        return Price * 0.05;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Model: {Model}, Price: {Price}, Tax: {GetTax()}");
    }
}

public class Car : Vehicle
{
    private int seats;

    public int Seats
    {
        get { return seats; }
        set { seats = value; }
    }

    public Car(string model, double price, int seats)
        : base(model, price)
    {
        Seats = seats;
    }

    public override double GetTax()
    {
        return Price * 0.08;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Car - Model: {Model}, Price: {Price}, Seats: {Seats}, Tax: {GetTax()}");
    }
}

public class Truck : Vehicle
{
    private double capacityTon;

    public double CapacityTon
    {
        get { return capacityTon; }
        set { capacityTon = value; }
    }

    public Truck(string model, double price, double capacityTon)
        : base(model, price)
    {
        CapacityTon = capacityTon;
    }

    public override double GetTax()
    {
        return Price * 0.10;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Truck - Model: {Model}, Price: {Price}, Capacity: {CapacityTon} ton(s), Tax: {GetTax()}");
    }
}

public class Program
{
    public static void Main()
    {
        Vehicle v1 = new Car("Sedan", 1500000, 5);
        Vehicle v2 = new Truck("Cargo", 2800000, 10);
        Vehicle v3 = new Vehicle("Car", 2800000);

        Vehicle[] vehicles = { v1, v2, v3 };

        foreach (Vehicle v in vehicles)
        {
            v.ShowInfo(); // polymorphic call
        }
    }
}
