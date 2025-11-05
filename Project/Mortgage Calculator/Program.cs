// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.Write("Enter loal ammount: ");
string loanammounts = Console.ReadLine(); 

Console.Write("Enter annual interenst rate (in %): ");
string interenstrates = Console.ReadLine();

double loanammount = double.Parse(loanammounts);
double interestrate = double.Parse(interenstrates);

interestrate = interestrate / 100;

Console.Write("Enter loan in years: ");
string loanterms = Console.ReadLine();  

int loanterm = int.Parse(loanterms);
loanterm = loanterm * 12;

double monthlypayment = (loanammount * (interestrate / 12) * Math.Pow(1 + (interestrate / 12), loanterm)) / (Math.Pow(1 + (interestrate / 12), loanterm) - 1);

Console.WriteLine("Your monthly payment is: " + monthlypayment);

double totalpaid = monthlypayment * loanterm;
double totalinterest = totalpaid - loanammount;

        CultureInfo bdCulture = new CultureInfo("bn-BD");

        Console.WriteLine("Mothly Payment: "+ monthlypayment.ToString("C", bdCulture));
        Console.WriteLine("Total paid: " + totalpaid.ToString("C", bdCulture));
        Console.WriteLine("Total interest: " + totalinterest.ToString("C", bdCulture));
  