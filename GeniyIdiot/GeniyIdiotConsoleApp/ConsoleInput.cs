using GeniyIdiotClassLibrary;
using GeniyIdiotConsoleApp;
using Newtonsoft.Json;
namespace GeniusIdiotConsoleApp
{
    public static class ConsoleInput
    {
        private static readonly string Yellow = "\x1b[33m";
        private static readonly string Bold = "\x1b[1m";
        private static readonly string Reset = "\x1b[0m";
        public static int GetInt(int min, int max)
        {
            var userAnswer = 0;
            while (true)
            {
                try
                {
                    userAnswer = Convert.ToInt32(Console.ReadLine());
                    if (userAnswer >= min && userAnswer <= max)
                    {
                        return userAnswer;
                    }
                    Console.WriteLine($"Некорректный ввод. Нужно ввести целое число от {min} до {max}. Попробуй снова!");
                }
                catch
                {
                    Console.WriteLine($"Некорректный ввод. Нужно ввести целое число от {min} до {max}. Попробуй снова!");
                }
            }
        }
        public static bool GetConfirmation(string message)
        {
            Console.WriteLine(message);
            while (true)
            {
                var userAnswer = Console.ReadLine().ToLower().Trim();
                if (string.IsNullOrWhiteSpace(userAnswer))
                {
                    Console.WriteLine("Некорректный ввод, ты ввел пустое значение! Пожалуйста, попробуй снова!");
                }
                else
                {
                    if (userAnswer == "да")
                    {
                        return true;
                    }
                    if (userAnswer == "нет")
                    {
                        return false;
                    }
                    Console.WriteLine("Некорректный ввод! Пожалуйста, введи в консоль \"Да\" или \"Нет\"!");
                }
            }
        }
        public static void WaitForKeyPress()
        {
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey(true);
        }
        public static User CreateUser()
        {
            var lastName = GetUserFIO("Пожалуйста, введи свою фамилию только на русской раскладке!");
            var firstName = GetUserFIO("Пожалуйста, введи свое имя только на русской раскладке!");
            var patronymic = GetUserPatronymic();
            var user = new User(firstName, lastName, patronymic);
            return user;
        }
        public static void ShowQuizHistory()
        {
            Console.WriteLine("ТАБЛИЦА ПРЕДЫДУЩИХ РЕЗУЛЬТАТОВ ИГРЫ");
            Console.WriteLine("|| {0,-60} || {1,-15} || {2,-30} ||", "ФИО", "ДИАГНОЗ", "КОЛИЧЕСТВО ПРАВИЛЬНЫХ ОТВЕТОВ");
            var quizResults = UserResultStorage.GetQuizHistory();
            foreach (var result in quizResults)
            {
                Console.WriteLine("|| {0,-60} || {1,-15} || {2,-30} ||", result.FullName, result.Diagnose.Name, result.RightAnswerCount);
            }
        }
        public static void PlayMainQuiz(User user)
        {
            while (true)
            {
                var userFullName = user.FullName;
                Console.WriteLine($"{userFullName}, давай приступим к вопросам! У тебя есть 15 секунд на то, чтобы дать ответ!{Environment.NewLine}" +
                    $"Не успеешь — ответ не засчитывается даже если он будет правильным!{Environment.NewLine}" +
                    $"Набирай свой ответ на клавиатуре, а чтобы его отправить - жми Enter. Удачи!");
                var rightAnswersCount = 0;
                var questionAndAnswers = QuestionStorage.GetAll();
                var randomIndexes = Randomizer.GetRandomIndexes(questionAndAnswers.Count);

                for (var i = 0; i < questionAndAnswers.Count; i++)
                {
                    WaitForKeyPress();
                    Console.Clear();
                    var randomQuestionIndex = randomIndexes[i];
                    Console.WriteLine($"{Bold}{Yellow}Вопрос №{i + 1}:{Reset}");
                    Console.WriteLine($"{Bold}{Yellow}{questionAndAnswers[randomQuestionIndex].Message}{Reset}");
                    ConsoleTimer.StartTimer();
                    var userAnswer = GetInt(int.MinValue, int.MaxValue);
                    ConsoleTimer.StopTimer();
                    var rightAnswer = questionAndAnswers[randomQuestionIndex].RightAnswer;
                    if (userAnswer == rightAnswer && !ConsoleTimer.CheckTimeIsOver())
                    {
                        rightAnswersCount++;
                    }
                }
                Console.WriteLine($"Количество правильных ответов: {rightAnswersCount}");
                user.Diagnose = DiagnosesStorage.GetDiagnoseAssesment(rightAnswersCount, questionAndAnswers.Count);
                user.RightAnswerCount = rightAnswersCount;
                UserResultStorage.SaveQuizResultToFile(user);
                Console.WriteLine($"{userFullName}, твой диагноз: {user.Diagnose.Name}");
                if (!GetConfirmation("Хочешь сыграть еще один раунд? Введи \"Да\" или \"Нет\""))
                {
                    break;
                }
                Console.Clear();
            }
        }
        public static void AddQuestion()
        {
            var questions = QuestionStorage.GetAll();
            while (true)
            {
                Console.Clear();
                var message = AddMessage();
                var rightAnswer = AddAnswer();
                questions.Add(new Question(message, rightAnswer));
                Console.WriteLine("Вопрос успешно добавлен!");
                if (!GetConfirmation("Хочешь добавить еще вопрос? Введи \"Да\" или \"Нет\""))
                {
                    break;
                }
            }
            QuestionStorage.RewriteFile(questions);
        }
        public static void DeleteQuestions()
        {
            var questions = QuestionStorage.GetAll();
            var continueDeleting = true;
            while (questions.Count > 5 && continueDeleting)
            {
                Console.WriteLine($"Количество вопросов, доступных для удаления: {questions.Count - 5}.");
                var deleteQuestionIndex = 0;
                var avaliableQuestionIndexex = new List<int>();
                for (var i = 5; i < questions.Count; i++)
                {
                    Console.WriteLine($"Индекс вопроса №{i}: {questions[i].Message}");
                    avaliableQuestionIndexex.Add(i);
                }
                while (true)
                {
                    Console.WriteLine("Какой вопрос хотите удалить? Введите индекс этого вопроса!");
                    deleteQuestionIndex = GetInt(5, questions.Count - 1);
                    if (Question.IsAvaliableIndex(avaliableQuestionIndexex, deleteQuestionIndex))
                    {
                        break;
                    }
                    Console.WriteLine("Некорректный ввод. Вы ввели неправильный индекс! Попробуйте снова!");
                }
                if (GetConfirmation($"Ты точно хочешь удалить вопрос: \"{questions[deleteQuestionIndex].Message}\"? Введи \"Да\" или \"Нет\""))
                {
                    questions.RemoveAt(deleteQuestionIndex);
                }
                if (questions.Count == 5)
                {
                    Console.WriteLine("Недостаточно вопросов для удаления. Операция удаления вопросов недоступна.");
                    break;
                }
                continueDeleting = ConsoleInput.GetConfirmation("Ты хочешь удалить еще вопрос? Введи \"Да\" или \"Нет\"");
            }
            var jsonData = JsonConvert.SerializeObject(questions);
            QuestionStorage.RewriteFile(questions);
        }
        private static string GetUserPatronymic()
        {
            var isUserHavePatronymic = GetConfirmation("У тебя есть отчество? Введите \"Да\" или \"Нет\".");
            var patronymic = "";
            if (isUserHavePatronymic)
            {
                patronymic = GetUserFIO("Пожалуйста, введи свое отчество только на русской раскладке!");
            }
            return patronymic;
        }
        private static string GetUserFIO(string message)
        {
            var userInput = string.Empty;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine(message);
                    userInput = Console.ReadLine();
                    if (InputValidator.CheckNameIsValid(userInput, out string errorMessage))
                    {
                        break;
                    }
                    Console.WriteLine(errorMessage);
                    Console.WriteLine("Попробуй снова!");
                }
                userInput = InputValidator.NormalizeName(userInput);
                if (GetConfirmation($"Подтвердите ввод: {userInput}. Введите \"Да\" или \"Нет\"."))
                {
                    return userInput;
                }
            }
        }
        private static string AddMessage()
        {
            Console.WriteLine($"Тебе необходимо создать новый вопрос, который будет предложен другим игрокам.{Environment.NewLine}Правила " +
                            $"составления:{Environment.NewLine}1. Вопрос должен быть сформулирован в повествовательно-вопросительной форме " +
                            $"(заканчиваться вопросительным знаком) на РУССКОМ языке.{Environment.NewLine}2. Ответом на вопрос должно быть целое " +
                            $"число.{Environment.NewLine}3. Соблюдай правила русского языка, логику и здравый смысл, а также старайся не делать опечатки!");
            var questionMessage = string.Empty;

            while (true)
            {
                var errorMessage = "";
                questionMessage = Console.ReadLine().TrimEnd('?');

                if (!InputValidator.CheckSentenceIsValid(questionMessage, out errorMessage))
                {
                    Console.WriteLine(errorMessage);
                    continue;
                }
                break;
            }

            questionMessage = InputValidator.NormalizeQuestion(questionMessage);
            var message = $"Проверь правильность ввода своего вопроса. Мы попытались максимально отредактировать твою " +
                $"строку, но проверить абсолютно все не в силах! {Environment.NewLine}Подтверждаешь ввод вопроса \"{questionMessage}\"? " +
                $"Введите \"Да\" или \"Нет\".";

            if (GetConfirmation(message))
            {
                return questionMessage;
            }
            Console.Clear();
            return AddMessage();
        }
        private static int AddAnswer()
        {
            Console.WriteLine($"Напиши ответ на свой вопрос! Напоминаем, что ответом на вопрос должно быть целое число!{Environment.NewLine}Пожалуйста, не" +
                $" забывай о логике и здравом смысле!");
            var questionAnswer = GetInt(int.MinValue, int.MaxValue);
            var message = $"Проверь правильность ответа на свой вопрос! {Environment.NewLine}Подтверждаешь ввод ответа \"{questionAnswer}\"? " +
                  $"Введите \"Да\" или \"Нет\".";

            if (GetConfirmation(message))
            {
                return questionAnswer;
            }
            return AddAnswer();
        }
    }
}


