using static System.Console;
Clear();

Write("Введите колличество строк: ");
int arrayString = int.Parse(ReadLine());
Write("Введите колличество столбцов: ");
int arrayColumn = int.Parse(ReadLine());
double[,] MyArray = new double[arrayString, arrayColumn];
FillArray(MyArray);
PrintArray(MyArray);
PrintAvg(MyArray, arrayString);

void FillArray(double[,] MyArray)
{
    for (int i = 0; i < MyArray.GetLength(0); i++)
    {
        for (int j = 0; j < MyArray.GetLength(1); j++)
        {
            MyArray[i, j] = Convert.ToDouble(new Random().Next(-99, 99));
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

void PrintAvg(double[,] MyArray, int arrayString)
{
    WriteLine("Среднее арифметическое элементов в каждом столбце: ");
    for (int j = 0; j < MyArray.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < MyArray.GetLength(0); i++)
        {
            avarage = (avarage + MyArray[i, j]);
        }
        avarage = avarage / arrayString;
        Write(avarage + "; ");
    }
    WriteLine();
}
