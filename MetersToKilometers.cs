Console.Write("Enter meters: ");
double m = double.Parse(Console.ReadLine());
double mconvertertokm = m / 1000;
Console.WriteLine($"{m} meters = {mconvertertokm:F2} kilometers");