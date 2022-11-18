// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Введите коэффициент k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
int k2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = int.Parse(Console.ReadLine());

if (k1 == k2 & b1 == b2) 
{
    Console.WriteLine($"Прямые y={k1}*x +({b1}), y={k2}*x +({b2}) - совпадают.");
}
else if (k1 == k2)
{
    Console.WriteLine($"Прямые y={k1}*x +({b1}), y={k2}*x +({b2}) - параллельные.");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых y={k1}*x +({b1}), y={k2}*x +({b2}) имеет координаты ({x}, {y}).");
}
