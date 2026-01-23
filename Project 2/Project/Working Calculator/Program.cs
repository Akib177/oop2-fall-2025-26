// See https://aka.ms/new-console-template for more information


string ans;

do
{
    Console.WriteLine("Enter 2 values for calculation: ");

    string a = Console.ReadLine();
    string b = Console.ReadLine();


    float af = float.Parse(a);
    float bf = float.Parse(b);

    Console.Write("Enter a calculation method (+,-,*,/) : ");

    string method = Console.ReadLine();

    if (method == "+")
    {
        float c = af + bf;
        Console.WriteLine("Sum of two number is: " + c);
    }
    else if (method == "-")
    {
        float c = af - bf;
        Console.WriteLine("Substract of two number is: " + c);
    }
    else if (method == "*")
    {
        float c = af * bf;
        Console.WriteLine("Multiplication of two numbers is: " + c);
    }
    else if (method == "/")
    {
        if (bf == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            float c = af / bf;
            Console.WriteLine("Divide of two number is: " + c);
        }
    }
    else
    {
        Console.WriteLine("Enter a valid calculation method (+,-,*,/)");
    }
    Console.WriteLine("Do you want to calculate more? (y/n)");
    ans = Console.ReadLine();

} while (ans.ToLower()=="y");



