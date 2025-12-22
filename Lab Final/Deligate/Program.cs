using Delegate;

namespace Delegate
{
    public delegate int Operation(int a, int b);
}

class Program
{
    static int add(int a, int b)
    {
        return a + b;
    }
    static int sub(int a, int b)
    {
        return a - b;
    }

    static void Calculate(int a, int b, Operation op)
    {
        int result = op(a, b);
        Console.WriteLine("Result is: " + result);
    }

    static void Main(string[] args)
    {
        Calculate(10, 20, add);
        Calculate(15, 5, sub);
    }

}