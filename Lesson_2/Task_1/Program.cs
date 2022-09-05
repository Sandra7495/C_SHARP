Console.Write("Введи трёхзначное число: ");
string Number = Console.ReadLine();
if (Number.Length == 3)
{
    int Num = Convert.ToInt32(Number);
    int n2 = Num % 100 / 10;
    Console.WriteLine("Вторая цифра этого числа = " + n2);
}
else 
{
    Console.WriteLine("Число не является трехзначным ");
}
   


 


