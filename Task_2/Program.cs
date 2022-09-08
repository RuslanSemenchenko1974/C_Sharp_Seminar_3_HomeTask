double Distance (int x1, int y1, int z1, int x2, int y2, int z2)
{
  double d = Math.Sqrt( Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
  return d;
}

Console.Clear();
    Console.WriteLine("Введите координаты первой точки : ");
    Console.Write(" X1 : ");
    int x1=Convert.ToInt32(Console.ReadLine());
    Console.Write(" Y1 : ");
    int y1=Convert.ToInt32(Console.ReadLine());
    Console.Write(" Z1 : ");
    int z1=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты второй точки : ");
    Console.Write(" X2 : ");
    int x2=Convert.ToInt32(Console.ReadLine());
    Console.Write(" Y2 : ");
    int y2=Convert.ToInt32(Console.ReadLine());
    Console.Write(" Z2 : ");
    int z2=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Расстояние : {Math.Round(Distance(x1,y1,z1,x2,y2,z2),2)}");
