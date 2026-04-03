using GeniyIdiotClassLibrary;
using System.ComponentModel;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuizPanel : UserControl
    {
        public event EventHandler QuizFinished;
        private User user;
        private List<Question> questions;
        private List<int> randomIndexes;
        private int currentIndex;
        private int questionNumber;
        private int currentQuestionIndex;
        private int rightAnswersCount;
        private int questionsCount;
        private int roundTime;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public User User
        {
            get => user;
            set
            {
                user = value;
                greetingsLabel.Text = $"{user.FullName}, начнем игровую сессию!";
            }
        }
        public QuizPanel()
        {
            InitializeComponent();
        }
        public void ResetQuiz()
        {
            MessageBox.Show($"Игровая сессия начинается!{Environment.NewLine}У тебя есть 15 секунд на ответ!{Environment.NewLine}" +
                $"Если время выйдет, то твой ответ, введённый в текстовое поле, будет автоматически засчитан!{Environment.NewLine}" +
                $"Пустой или неправильный ответ считается ошибкой!{Environment.NewLine}После истечения времени программа покажет следующий вопрос!");
            questionNumber = 1;
            rightAnswersCount = 0;
            currentQuestionIndex = 0;
            questions = QuestionStorage.GetAll();
            questionsCount = questions.Count;
            randomIndexes = Randomizer.GetRandomIndexes(questionsCount);
            currentIndex = randomIndexes[currentQuestionIndex];
            userAnswerTextBox.Clear();
            errorMessageLabel.Visible = false;
            ShowCurrentQuestion();
        }
        private void ShowCurrentQuestion()
        {
            currentIndex = randomIndexes[currentQuestionIndex];
            questionNumberLabel.Text = $"Вопрос №{questionNumber}";
            questionMessageLabel.Text = questions[currentIndex].Message;
            roundTime = 15;
            timeLeftProgressBar.Value = 15;
            roundTimer.Start();
        }
        private void userAnswerTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(userAnswerTextBox.Text);
                errorMessageLabel.Visible = false;
            }
            catch
            {
                errorMessageLabel.Visible = true;
                errorMessageLabel.Text = $"Некорректный ввод. Нужно ввести целое число от {int.MinValue} до {int.MaxValue}. Попробуйте снова!";
            }
        }
        private bool IsValidAnswer()
        {
            try
            {
                Convert.ToInt32(userAnswerTextBox.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void CheckRightAnswer()
        {
            if (!IsValidAnswer())
            {
                return;
            }
            if (Convert.ToInt32(userAnswerTextBox.Text) == questions[currentIndex].RightAnswer)
            {
                rightAnswersCount++;
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!IsValidAnswer())
            {
                errorMessageLabel.Visible = true;
                errorMessageLabel.Text = $"Некорректный ввод. Нужно ввести целое число от {int.MinValue} до {int.MaxValue}. Попробуйте снова!";
                return;
            }
            roundTimer.Stop();
            CheckRightAnswer();
            CheckEndQuiz();
        }
        private void CheckEndQuiz()
        {
            questionNumber++;
            currentQuestionIndex++;
            userAnswerTextBox.Clear();
            errorMessageLabel.Visible = false;
            if (currentQuestionIndex == randomIndexes.Count)
            {
                FinishQuiz();
            }
            else
            {
                ShowCurrentQuestion();
            }
        }
        private void FinishQuiz()
        {
            user.Diagnose = DiagnosesStorage.GetDiagnoseAssesment(rightAnswersCount, questionsCount);
            user.RightAnswerCount = rightAnswersCount;
            MessageBox.Show($"{user.FullName}, твой диагноз - {user.Diagnose.Name}!");
            UserResultStorage.SaveQuizResultToFile(user);
            QuizFinished?.Invoke(this, EventArgs.Empty);
        }
        private void roundTimer_Tick(object sender, EventArgs e)
        {
            roundTime--;
            timeLeftProgressBar.Value--;
            if (roundTime <= 0)
            {
                roundTimer.Stop();
                MessageBox.Show("Время вышло!");
                CheckRightAnswer();
                CheckEndQuiz();
            }
        }
    }
}
