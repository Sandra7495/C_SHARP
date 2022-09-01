Console.Write("Введите 1е число ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);

Console.Write("Введите 2е число ");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);

Console.Write("Введите 3е число ");
string number3 = Console.ReadLine();
int num3 = Convert.ToInt32(number3);

if (num1 > num2)
{
    if (num1 > num3)
    {
      Console.Write("Максимальное число");
      Console.WriteLine (num1);
    }
    else
    {
      Console.Write("Максимальное число");
      Console.WriteLine (num3); 
    }
}
else
{
     if (num2 > num3)
     {
       Console.Write("Максимальное число");
      Console.WriteLine (num2); 
     }
     else
    {
      Console.Write("Максимальное число");
      Console.WriteLine (num3); 
    }
}
