// на вход число которое выдает четное или нет(делится ли оно на 2 без остатка)
//4 ->да
//-3->нет
//7 ->нет

Console.WriteLine("ввести первое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 ==0)
{
    Console.WriteLine("остатка нет.Все верно");
}
else
{
    Console.WriteLine("Это нечетное число");
}