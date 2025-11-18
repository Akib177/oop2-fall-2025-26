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

int result = Math.Sum(5, 7);
Console.WriteLine("Sum of 5 and 7 is: " + result);
Console.WriteLine("Value of Pi is: " + Math.Pi);


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

public static class Math
{
    public static double Pi { get { return 3.14159; } }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}
