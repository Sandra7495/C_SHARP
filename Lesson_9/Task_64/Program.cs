using static System.Console;
Clear();

Console.WriteLine("Введите число от 1 до 1000:");
int number = int.Parse(Console.ReadLine());
interNumbers(number);

void interNumbers (int number)
{
    if (number == 0) return;
    Console.Write(number + " ");
    interNumbers (number - 1);
}

