//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
//Написать программу масштабирования фигуры
 void getCoefficients(out double k1, out double b1, out double k2, out double b2)
{
    Console.WriteLine("Введите b1");
    b1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите k1");
    k1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите b2");
    b2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите k2");
    k2 = double.Parse(Console.ReadLine());
}
void analysis(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1==k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
    double x=(b2-b1)/(k1-k2);
    double y=(k1*(b2-b1))/(k1-k2)+b1;
    Console.WriteLine($"({x};{y})");
    }
}
Console.WriteLine("Введите коэффициенты уравнений прямых y = k1 * x + b1, y = k2 * x + b2: ");
getCoefficients(out double k1, out double b1, out double k2, out double b2);
analysis(k1, b1, k2, b2);