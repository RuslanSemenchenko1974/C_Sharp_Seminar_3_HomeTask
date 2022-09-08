// Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Boolean CheckNumber(int number) //Метод определяет является ли number палиндром 
{
string num=Convert.ToString(number);
    int lengthNum=num.Length;  
    int count=lengthNum/2;     
    Boolean tr = false;
    
    for (int i = 0; i<=count; i++) 
    {
        if (num[i]==num[lengthNum-i-1]) tr=true;
        else return false;

    }
    return true;
}
Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number>99999||number<10000) Console.WriteLine("Неправильный ввод!");
else
{
    if (CheckNumber(number)==true) Console.WriteLine("Палиндром");
    else Console.WriteLine("НЕ палиндром");
}
 