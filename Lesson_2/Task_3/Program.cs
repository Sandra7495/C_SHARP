Console.Write("Введи числом день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день ");
}
else if (day < 1 || day > 7)
{
    Console.WriteLine("В неделе 7 дней ");
}
else
{
    Console.WriteLine("Будний день "); 
}