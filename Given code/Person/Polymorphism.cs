Person person = new Person();
Employee employee = new Employee();
Customer customer = new Customer();

person.Greeting();
employee.Greeting();
customer.Greeting();

public class Person
{
    public virtual void Greeting()
    {
        Console.WriteLine("Hello from Person class!");
    }
}

public class Employee : Person
{
    public override void Greeting()
    {
        Console.WriteLine("Hello from Employee class!");
    }
}

public class Customer : Person
{
    public override void Greeting()
    {
        Console.WriteLine("Hello from Customer class!");
    }
}