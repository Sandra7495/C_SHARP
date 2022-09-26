using static System.Console;
Clear();

double[,] MyArray = new double[5, 5];
FillArray(MyArray);
PrintArray(MyArray);

Write("Введите номер строки: ");
int y = int.Parse(ReadLine());
Write("Введите номер столбца: ");
int x = int.Parse(ReadLine());
SearchElement(MyArray, y, x);

void FillArray(double[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] = Convert.ToDouble(new Random().Next(10, 99));
        }
    }
}

void PrintArray(double[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            Write(MyArray[i, j] + " ");
        }
        WriteLine("");
    }
}

void SearchElement(double[,] MyArray, int y, int x)
{
    if (y > MyArray.GetLength(0) || x > MyArray.GetLength(1))
    {
        WriteLine("элемента нет");
    }
    else
    {
        WriteLine($"Значение элемента равно: {MyArray[y-1,x-1]}");
    }
}