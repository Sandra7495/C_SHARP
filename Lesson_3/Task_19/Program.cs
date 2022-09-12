Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
if (number.Length == 5)
{
  CheckNumber(number);
}
else Console.WriteLine($"Это не пятизначное число ");

void CheckNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - не палиндром.");
}