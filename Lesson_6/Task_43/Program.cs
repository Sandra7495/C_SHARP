using static System.Console;
Clear();

Write("Введите значения b1, k1, b2 и k2 через пробел: ");
double[] Values = Array.ConvertAll(ReadLine().Split(), double.Parse);
double x = (-Values[2] + Values[0])/(-Values[1] + Values[3]);
double y = Values[3] * x + Values[2];
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}"); 


