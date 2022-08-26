Console.WriteLine("Введите трехзначное число:");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 100 || n > 999)
{
    Console.WriteLine("Я сказал ТРЕХзначное, попробуй еще раз");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine((n / 10) % 10);

