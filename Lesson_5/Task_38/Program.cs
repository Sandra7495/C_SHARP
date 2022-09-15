using static System.Console;
Clear();

double[] nums = {2, 5, 4, 6, 8};
WriteLine(String.Join (" ", nums));


double min = nums[0];
double max = nums[0];

for (int i = 0; i < nums.Length; i++)
{
    if (max < nums[i])
    {
        max = nums[i];
    } 
    
    if (min > nums[i])
    {
        max = nums[i];
    }
        
}
double result = max - min;
WriteLine($"Разница между максимальным и минимальным элементов массива = {result}");