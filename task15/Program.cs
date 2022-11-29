Console.Write("Введите цифру, обозначающую день недели:");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 1 && n < 6)
Console.Write("нет");
if (n == 6 || n ==7)
Console.Write("да");
if (n < 1 || n > 7) 
Console.Write($"Введите корректные данные (от 1 до 7)");