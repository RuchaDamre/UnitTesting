class Program
{
static void Main(String [] args)
{

int num = Add(4,5);

Console.WriteLine(isOdd(5));
Console.WriteLine(num);

}
public static int Add(int x, int y)
{
return x+y;

}
public static bool isOdd(int value)
{
return value%2==1;

}

}
