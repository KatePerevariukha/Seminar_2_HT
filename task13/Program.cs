Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.Write("Третья цифра отсутствует");
else
{    while (n > 999)
        n = n / 10;
    Console.WriteLine(n % 10);
}