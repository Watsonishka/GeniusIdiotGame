using GeniyIdiotClassLibrary;

namespace GeniusIdiotConsoleApp
{
    public static class ConsoleMainMenu
    {
        public static void Show()
        {
            Console.WriteLine("=== ГЕНИЙ ИДИОТ ===");
            Console.WriteLine("1. Начать игру");
            Console.WriteLine("2. Посмотреть предыдущие результаты игры");
            Console.WriteLine("3. Добавить вопрос");
            Console.WriteLine("4. Удалить вопрос");
            Console.WriteLine("5. Выйти");
        }
        public static void GetMenuChoice(User user)
        {
            while (true)
            {
                Console.Clear();
                Show();
                Console.WriteLine($"{user.FullName}, введи номер пункта меню:");

                var userMenuChoice = ConsoleInput.GetInt(1, 5);

                if (userMenuChoice == 1)
                {
                    Console.Clear();
                    ConsoleInput.PlayMainQuiz(user);
                    ConsoleInput.WaitForKeyPress();
                }
                else if (userMenuChoice == 2)
                {
                    Console.Clear();
                    ConsoleInput.ShowQuizHistory();
                    ConsoleInput.WaitForKeyPress();
                }
                else if (userMenuChoice == 3)
                {
                    Console.Clear();
                    ConsoleInput.AddQuestion();
                    ConsoleInput.WaitForKeyPress();
                }
                else if (userMenuChoice == 4)
                {
                    var questions = QuestionStorage.GetAll();
                    if (questions.Count <= 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Недостаточно вопросов для удаления. Операция удаления вопросов недоступна.");
                        ConsoleInput.WaitForKeyPress();
                    }
                    else
                    {
                        Console.Clear();
                        ConsoleInput.DeleteQuestions();
                        ConsoleInput.WaitForKeyPress();
                    }
                }
                else
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}

