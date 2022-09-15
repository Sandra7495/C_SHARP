﻿using static System.Console;
Clear();

int[] array = GetArray(8,1,10);
WriteLine(String.Join (" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

