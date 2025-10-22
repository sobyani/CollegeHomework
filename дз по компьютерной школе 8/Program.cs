class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Введите новое число,чтобы вычеслить факториал:");
        string Number = Console.ReadLine();
        int n = Convert.ToInt32(Number);
        int a = 1;
        if (n < 0)
        {
            Console.WriteLine("это невозможно");
            return;
        }
        for (int i = 1; i <= n;  i++)
        {
            a  = a  * i;
            if (i == n)
            {

                Console.WriteLine($"факториал числа {n}:{a}");
            }
            
        }
    }
}
