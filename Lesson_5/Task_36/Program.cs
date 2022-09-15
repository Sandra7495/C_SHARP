using static System.Console;
Clear();

int[] array = GetArray(9,1,10);
WriteLine(String.Join (" ", array));
int result = SumNumbers(array);
WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int SumNumbers(int[] array)
{    
    result = 0;                      
    for (int i = 0; i < array.Length; i++)
    {
        if (i %2 != 0)
        {
           result = result + array[i];
        }  
    }
    return result;
}