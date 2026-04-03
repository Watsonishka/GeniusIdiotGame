namespace GeniusIdiotConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ты попал в консольную игру \"Гений-Идиот\"! Необходимо записать твое ФИО! ");
            var user = ConsoleInput.CreateUser();
            Console.WriteLine($"Приветствую тебя, {user.FullName}! Твое имя зафиксировано.");
            ConsoleInput.WaitForKeyPress();
            ConsoleMainMenu.GetMenuChoice(user);
            Console.WriteLine($"{user.FullName}, до новых встреч!");
            Environment.Exit(0);
        }
    }
}

