using System.Timers;
using Timer = System.Timers.Timer;

namespace GeniyIdiotConsoleApp
{
    public static class ConsoleTimer
    {
        private static Timer quizTimer = new Timer(1000);
        private static int timeTick;
        private const int timeLimit = 15;
        private static int leftTime;
        private static bool timeIsOver;
        private static int timerLineTop;

        public static void StartTimer()
        {
            timerLineTop = Console.CursorTop;
            Console.WriteLine($"Таймер запущен! Осталось времени: 15 секунд");
            Console.Write("Твой ответ: ");
            timeIsOver = false;
            timeTick = 0;
            quizTimer.Elapsed += QuizTimer_Elapsed;
            quizTimer.AutoReset = true;
            quizTimer.Start();
        }
        public static bool CheckTimeIsOver()
        {
            return timeIsOver;
        }
        public static void StopTimer()
        {
            quizTimer.AutoReset = false;
            quizTimer.Stop();
            //quizTimer.Dispose();
            quizTimer.Elapsed -= QuizTimer_Elapsed;
        }
        private static void QuizTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            timeTick++;
            leftTime = timeLimit - timeTick;
            var currentLeft = Console.CursorLeft;
            var currentTop = Console.CursorTop;
            Console.SetCursorPosition(0, timerLineTop);
            Console.Write($"Таймер запущен! Осталось времени: {leftTime} секунд ");
            Console.SetCursorPosition(currentLeft, currentTop);

            if (leftTime == 0)
            {
                timeIsOver = true;
                StopTimer();
                Console.WriteLine($"Время вышло! Все равно введи свой ответ, чтобы продолжить игру!{Environment.NewLine}" +
                    $"Напоминаем, что тебе его не засчитают как правильный в любом случае!");
            }
        }
    }
}
