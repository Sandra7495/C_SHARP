using static System.Console;
Clear();

int[] array = GetArray(6,100,999);
WriteLine(String.Join (" ", array));
int result = EvenNumbers(array);
WriteLine($"Колличество четных чисел = {result}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int EvenNumbers(int[] array)
{    
    result = 0;                      
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
        {
           result++;
        }  
    }
    return result;
}