using Homework_14;

class Program
{
    static void Main(string[] args)
    {
        ITaskService taskService = new TaskService();
        ConsoleMenu menu = new ConsoleMenu(taskService);
        menu.ShowMenu();
    }
}