class Program
{
    delegate double MathOperation(double a, double b);

    static double Calculate(double x, double y, MathOperation operation)
    {
        return operation(x, y);
    }

    static void Main()
    {
        Console.WriteLine("--- Универсальный калькулятор ---");

        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\n--- Результаты вычислений ---");

        Console.WriteLine($"Сложение: {Calculate(num1, num2, (a, b) => a + b)}");
        Console.WriteLine($"Вычитание: {Calculate(num1, num2, (a, b) => a - b)}");
        Console.WriteLine($"Умножение: {Calculate(num1, num2, (a, b) => a * b)}");

        if (num2 != 0)
        {
            Console.WriteLine($"Деление: {Calculate(num1, num2, (a, b) => a / b)}");
        }
        else
        {
            Console.WriteLine("Деление: Ошибка (деление на ноль)");
        }
    }
}