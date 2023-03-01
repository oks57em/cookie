// на вход принимает 2 числа и выдает какое больше и какое меньше
//a=5;b=7->max=7
//a=2;b=10->max=10
//a=-9;b=-3-=max-3
Console.WriteLine("ввести число:");
int numbera=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести второе число:");
int numberb=Convert.ToInt32(Console.ReadLine());
if (numbera >numberb)
{
    Console.WriteLine("первое число больше");
}
else    
{
    Console.WriteLine("второе число больше");
}