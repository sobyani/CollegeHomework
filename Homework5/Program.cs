using Homework5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Демонстрация работы глобального кэша (Singleton) ---");

        CacheService cache1 = CacheService.GetInstance();

        CacheService cache2 = CacheService.GetInstance();

        Console.WriteLine("Добавляем данные в кэш через первую ссылку...");
        cache1.Add("ConnectionString", "Server=.;Database=CacheDB;");
        cache1.Add("ApiKey", "XYZ12345ABC");

        Console.WriteLine("Получаем данные из кэша через ВТОРУЮ ссылку...");
        var connectionString = cache2.Get("ConnectionString");
        var apiKey = cache2.Get("ApiKey");

        Console.WriteLine($"Значение по ключу 'ConnectionString': {connectionString}");
        Console.WriteLine($"Значение по ключу 'ApiKey': {apiKey}");

        Console.WriteLine("Проверяем, что обе переменные ссылаются на один объект...");
        bool areSame = object.ReferenceEquals(cache1, cache2);
        Console.WriteLine($"Результат: {areSame}");
    }
}
