Console.Write("Введите 3-х значное число:");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 100;
int n2 = n % 10;
if (n > 99 && n < 1000)
Console.Write((n - n1*100 -n2) / 10);
else
Console.Write("Пожалуйста, введите 3-х значное число !!!");