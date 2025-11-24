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

        double addition = Calculate(num1, num2, (a, b) => a + b);
        Console.WriteLine($"Сложение: {addition}");

        double subtraction = Calculate(num1, num2, (a, b) => a - b);
        Console.WriteLine($"Вычитание: {subtraction}");

        double multiplication = Calculate(num1, num2, (a, b) => a * b);
        Console.WriteLine($"Умножение: {multiplication}");

        if (num2 != 0)
        {
            double division = Calculate(num1, num2, (a, b) => a / b);
            Console.WriteLine($"Деление: {division}");
        }
        else
        {
            Console.WriteLine("Деление: ошибка (деление на ноль)");
        }
    }
}
