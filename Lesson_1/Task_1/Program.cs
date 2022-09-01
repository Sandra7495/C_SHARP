Console.Write("Введите 1е число ");
string number1 = Console.ReadLine();
int num1 = Convert.ToInt32(number1);

Console.Write("Введите 2е число ");
string number2 = Console.ReadLine();
int num2 = Convert.ToInt32(number2);

if ( num1 > num2 )
{
    Console.Write("Большее ");
    Console.WriteLine(num1);
}
else
{
    Console.Write("Большее ");
    Console.WriteLine(num2);
}

