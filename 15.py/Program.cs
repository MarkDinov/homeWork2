Console.WriteLine("Введите номер дня недели:");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.WriteLine("Это не является днем недели");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7)
    Console.WriteLine("Отдыхай!");
else
    Console.WriteLine("Работай!");
