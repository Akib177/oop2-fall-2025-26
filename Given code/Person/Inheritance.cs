Person person = new Person("Charlie");
Employee employee = new Employee("David", "Manager");

Console.WriteLine("Person Name: " + person.Name + ", ID: " + person.GetID());
Console.WriteLine("Employee Name: " + employee.Name + ", Role: " + employee.Role + ", ID: " + employee.GetID());
Console.WriteLine("Employee Salary: $" + employee.GetSalary());

public interface ISalary
{
    decimal GetSalary();
}

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual string GetID()
    {
        return Name.ToLower();
    }
}

public class Employee : Person, ISalary
{
    public string Role { get; set; }
    public Employee(string name, string role) : base(name)
    {
        Role = role;
    }

    public override string GetID()
    {
        return $"{base.GetID()}_{Role.ToLower()}";
    }

    public decimal GetSalary()
    {
        return 50000.00m;
    }
}