using static System.Console;
Clear();

Console.WriteLine("Введите первое число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите последнее число N:");
int numberN = int.Parse(Console.ReadLine());
GapNumberSum(numberM, numberN, 0);

void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + numberM;
    numberM++;
    GapNumberSum(numberM, numberN, sum);
}

