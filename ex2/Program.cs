
Console.WriteLine("Введите количество точек у фигуры ");
int count = int.Parse(Console.ReadLine());
Console.Write("Введите k: ");
double k = double.Parse(Console.ReadLine());
void Answer(double x, double y)
{  
    x = k*x; 
    y = k*y;
    Console.WriteLine($"({x};{y})");
}
for (int i = 0; i < count; i++)
{
    Console.Write("Введите x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y: ");
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine();
    Answer(x, y);
}

