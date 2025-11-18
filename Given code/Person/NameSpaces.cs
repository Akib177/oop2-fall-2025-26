namespace NameSpaces.Data
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

}

using NameSpaces;
using NameSpaces.Data;
using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("John", "Doe");
        House house = new House("123 Main St", 4);

        Console.WriteLine("Person: " + person);
        Console.WriteLine("House: " + house);
    }
}

namespace NameSpaces
{
    public class House
    {
        public string Address { get; set; }
        public int NumberOfRooms { get; set; }

        public House(string address, int numberOfRooms)
        {
            Address = address;
            NumberOfRooms = numberOfRooms;
        }

        public override string ToString()
        {
            return $"{Address}, Rooms: {NumberOfRooms}";
        }
    }
}

