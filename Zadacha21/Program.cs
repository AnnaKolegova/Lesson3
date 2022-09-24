void FillArray(int[]point)
{
    for (int index=0;index<3;index++)
    {
        point[index]=new Random().Next(1,10);
    }
}
void PrintArray(int[]point)
{
    for (int index=0;index<3;index++)
    {
        Console.Write($"{point[index]}  ");
    }
}
int[] point1=new int[3];
int[] point2=new int[3];
Console.WriteLine("Первая точка");
FillArray(point1);
PrintArray(point1);
Console.WriteLine( );
Console.WriteLine("Вторая точка");
FillArray(point2);
PrintArray(point2);

int Dist(int[]point1, int[]point2)
{int s=0;
int d=0;
    for (int index=0; index<3;index++)
    {
    d=(point1[index]-point2[index])*(point1[index]-point2[index]);
    s=s+d;
    }
  return (s);
}

int distan=Dist(point1, point2);
Console.WriteLine( );
Console.WriteLine($"Расстояние между точками равно - {Math.Sqrt(distan)}");