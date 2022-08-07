Console.WriteLine("Введите первое число");
int FNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int SNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int TNumber = int.Parse(Console.ReadLine());
if (FNumber > SNumber && FNumber > TNumber)
{
Console.WriteLine($"Максимальное число = {FNumber}"); 
}

else
{
    if (SNumber > FNumber && SNumber > TNumber)
    {
     Console.WriteLine($"Максимальное число = {SNumber}");    
    }
    else
    {
      Console.WriteLine($"Максимальное число = {TNumber}");  
    }
  
}
 
