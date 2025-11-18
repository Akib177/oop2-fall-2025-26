ICar testla = new TeslaModelS();
ICar bmw = new BMWi8();

System.Console.WriteLine($"Car Model: {testla.GetModel()}, Top Speed: {testla.GetTopSpeed()} mph");
System.Console.WriteLine($"Car Model: {bmw.GetModel()}, Top Speed: {bmw.GetTopSpeed()} mph");

public interface ICar
{
    string GetModel();
    int GetTopSpeed();
}

public class TeslaModelS : ICar
{

    public string GetModel()
    {
        return "Tesla Model S";
    }

    public int GetTopSpeed()
    {
        return 200;
    }
}

public class BMWi8 : ICar
{
    public string GetModel()
    {
        return "BMW i8";
    }

    public int GetTopSpeed()
    {
        return 155;
    }
}

