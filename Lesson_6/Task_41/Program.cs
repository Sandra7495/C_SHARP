using static System.Console;
Clear();

Write("Введите числа через запятую: ");
string[] StrArrNumbers = ReadLine().Split(",");
int count = CountNumbers(StrArrNumbers);
WriteLine($"Колличество чисел больше нуля = {count}");

int CountNumbers(string[] StrArrNumbers)
{
    int count = 0;
    for (int i = 0; i < StrArrNumbers.Length; i++)
    {
        if (int.Parse(StrArrNumbers[i]) > 0)
        {
            count++;
        }
    }
    return count;
}

