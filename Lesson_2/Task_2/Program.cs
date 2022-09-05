Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
if (stringNumber.Length > 2)
{
  Console.WriteLine("третья цифра = " + stringNumber[2]);
}
else {
  Console.WriteLine("= третьей цифры нет");
}