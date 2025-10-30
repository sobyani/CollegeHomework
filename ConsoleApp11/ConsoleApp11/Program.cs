using ConsoleApp11;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Создаем  прямоугольник 1 ---");
        Rectangle rect1 = new Rectangle(10, 5);

        Console.WriteLine($"Ширина: {rect1.Width}");
        Console.WriteLine($"Высота: {rect1.Height}");
        Console.WriteLine($"Площадь: {rect1.GetArea()}");
        Console.WriteLine($"Периметр: {rect1.GetPerimeter()}");

        Console.WriteLine("--- Создаем прямоугольник 1 ---");
        Rectangle rect2 = new Rectangle(15, 8);
        Console.WriteLine($"Ширина rect2: {rect2.Width}"); 
        Console.WriteLine($"Высота rect2: {rect2.Height}");
        Console.WriteLine($"Площадь: {rect2.GetArea()}");
        Console.WriteLine($"Периметр: {rect2.GetPerimeter()}");
    }
}