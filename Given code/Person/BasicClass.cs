

Person person1 = new Person();
Person person2 = new Person();

Console.WriteLine("Initial Person 1 Name: " + person1.Name);
Console.WriteLine("Initial Person 2 Name: " + person2.Name);
person1.Name = "Alice";
person2.Name = "Bob";
Console.WriteLine("Person 1 Name: " + person1.Name);
Console.WriteLine("Person 2 Name: " + person2.Name);

class Person
{
    private string _name; // field

    public Person()   // constructor
    {
        _name = "Unknown";
    }

    public string Name   // property
    {
        get { return _name; }
        set { _name = value; }
    }

}

Person person1 = new Person("Unknown");
Person person2 = new Person("Unknown");

Console.WriteLine("Initial Person 1 Name: " + person1.Name);
Console.WriteLine("Initial Person 2 Name: " + person2.Name);

person1.Name = "Alice";
person2.Name = "Bob";

Console.WriteLine("Person 1 Name: " + person1.Name);
Console.WriteLine("Person 2 Name: " + person2.Name);

person1.PrintGreeting();
person2.PrintGreeting();

Console.WriteLine(person1.GetGreeting());
Console.WriteLine(person2.GetGreeting());

Math math = new Math();
int result = math.Sum(5, 7);
Console.WriteLine("Sum of 5 and 7 is: " + result);


class Person
{

    public Person(string name)   // constructor
    {
        Name = name;
    }

    public string Name { get; set; } // auto-implemented property

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }

    public string GetGreeting()
    {
        return $"Person Name: {Name}";
    }

}

public class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}
