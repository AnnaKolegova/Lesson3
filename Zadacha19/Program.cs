void zadacha19()
{
    int number1=new Random().Next(10000,100000);
    Console.WriteLine($"число:{number1}");
    if ((number1/10000==number1%10) && (number1/1000%10==number1%100/10))
    {
        Console.WriteLine("число - палиндром");
    }
    else
    {
       
        Console.WriteLine("число не палиндром");
    }
    
}

zadacha19();