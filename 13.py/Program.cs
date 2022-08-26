Console.WriteLine("Введите число, а я покажу его третью цифру или скажу, что ее нет!");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("Третьей цифры нет :(");
else
    Console.WriteLine(Convert.ToString(n)[2]);
