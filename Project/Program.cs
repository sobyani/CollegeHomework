using Project;

class Program
{
    static void Main()
    {
        Library library = new Library();

        while (true)
        {
            UserInterface.ShowMenu();
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UserInterface.HandleAddBook(library);
                    break;
                case "2":
                    UserInterface.HandleRemoveBook(library);
                    break;
                case "3":
                    UserInterface.HandleFindBook(library);
                    break;
                case "4":
                    UserInterface.HandleShowAllBooks(library);
                    break;
                case "5":
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}