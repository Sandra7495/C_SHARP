Console.Write("Введите число ");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

int count = 1;

while (count <= num)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count ++;
}
