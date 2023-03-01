// на вход три числа и выдает максимальное
//2,3,7 ->7
//44,5,78 ->78
//22,3,9 ->22
Console.WriteLine("ввести первое число:");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести второе число:");
int numberb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ввести третье число:");
int numberc = Convert.ToInt32(Console.ReadLine());
int max = numbera;
if (numbera>max) max = numbera;
if (numberb>max) max = numberb;
if (numberc>max) max = numberc;
Console.Write("max =");
Console.WriteLine(max);
