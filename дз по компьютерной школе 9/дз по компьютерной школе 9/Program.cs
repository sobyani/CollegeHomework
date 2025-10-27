class Program
{
    public static void Main(string[] args)
    {
        int[] originalArray = { 10, 20, 30, 40, 50 };
        Console.Write("Исходный массив: ");
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.Write(originalArray[i] + " ");
        }
        Console.WriteLine();
        int[] reversedArray = new int[originalArray.Length];
        for (int i = 0; i < originalArray.Length; i++)
        {
            reversedArray[i] = originalArray[originalArray.Length - 1 - i];
        }
        Console.Write("Перевернутый массив: ");
        for (int i = 0; i < reversedArray.Length; i++)
        {
            Console.Write(reversedArray[i] + " ");
        }
        Console.WriteLine(); 
    }
}
