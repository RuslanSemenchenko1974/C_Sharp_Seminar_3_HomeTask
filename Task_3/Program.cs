// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void CubeNumbers(int namber) //Метод расчитывает куб числа
{
    if (namber==0) Console.WriteLine("0");
    else { if (namber>0)
              for (int i=1; i<=namber; i++)
               {
              Console.WriteLine($"{i} -> {Math.Pow(i,3)}");
               }
           if (namber<0)
               for (int i=1; i>=namber; i--)
               {
             Console.WriteLine($"{i} -> {Math.Pow(i,3)}");
               }
         }
}
Console.Clear();
Console.WriteLine("Введите число");
int namber=Convert.ToInt32(Console.ReadLine());
CubeNumbers(namber);