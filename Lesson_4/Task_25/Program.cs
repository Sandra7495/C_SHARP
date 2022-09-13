Console.Write("Введите число А: ");
double A = double.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
double B = double.Parse(Console.ReadLine());
double d = Math.Pow(A,B);
d = Math.Round(d,2);
Console.WriteLine($"d = {d} ");
