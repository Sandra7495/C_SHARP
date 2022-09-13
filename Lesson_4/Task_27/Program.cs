Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
while (number != 0)
{
    int i = number % 10;
    sum = sum + i;
    number = number / 10;
}
Console.WriteLine (sum);
