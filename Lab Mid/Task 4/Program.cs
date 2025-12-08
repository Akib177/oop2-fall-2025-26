// See https://aka.ms/new-console-template for more information


int a=5;
int b=10;
Console.WriteLine("Before Swap a: " + (a));
Console.WriteLine("Before Swap b: " + (b));

int temp=a;
a=b;
b=temp;

Console.WriteLine("After swap a: "+a);
Console.WriteLine("After swap b: "+b);
