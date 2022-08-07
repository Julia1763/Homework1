Console.WriteLine("Введите первое число");
int FNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SNumber = int.Parse(Console.ReadLine());
if (FNumber > SNumber)
{
Console.WriteLine($"Максимальное число = {FNumber}");
Console.WriteLine($"Минимальное число = {SNumber}");  
}

else
{
  Console.WriteLine($"Максимальное число = {SNumber}");
  Console.WriteLine($"Минимальное число = {FNumber}"); 
}
 