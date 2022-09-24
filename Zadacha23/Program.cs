void zadacha23()
{
    int number1=new Random().Next(1,10);
    Console.WriteLine($"число:{number1}");
    for (int index=1; index<=number1; index++)
    {
        Console.WriteLine ($"{index}^3={Math.Pow(index, 3)}");
    }
   
    
}

zadacha23();