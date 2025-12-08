// See https://aka.ms/new-console-template for more information


Console.Write("Enter 3 value: ");
int s1 = Convert.ToInt32(Console.ReadLine());
int s2 = Convert.ToInt32(Console.ReadLine());
int s3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Student 1 score is: " + s1);
Console.WriteLine("Student 2 score is: " + s2);
Console.WriteLine("Student 3 score is: " + s3);


float Avg = (s1 + s2 + s3) / 3.0f;

Console.WriteLine("Average is: " + Avg);


