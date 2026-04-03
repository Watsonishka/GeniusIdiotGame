using GeniyIdiotClassLibrary;
using System.ComponentModel;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainMenuPanel : UserControl
    {
        public event EventHandler<User> QuizSessionRequested;
        public event EventHandler QuizTableShowRequested;
        public event EventHandler AddQuestionsRequested;
        public event EventHandler DeleteQuestionsRequested;
        private User user;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public User User
        {
            get => user;
            set
            {
                user = value;
                greetingsUserLabel.Text = $"Приветствую тебя, {user.FullName}!";
            }
        }
        public MainMenuPanel()
        {
            InitializeComponent();
        }
        private void startQuizButton_Click(object sender, EventArgs e)
        {
            QuizSessionRequested?.Invoke(this, user);
        }
        private void showQuizTableButton_Click(object sender, EventArgs e)
        {
            QuizTableShowRequested?.Invoke(this, e);
        }
        private void addQuestionsButton_Click(object sender, EventArgs e)
        {
            AddQuestionsRequested?.Invoke(this, e);
        }
        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            DeleteQuestionsRequested?.Invoke(this, e);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            if (!ConfirmExit())
            {
                return;
            }
            Application.Exit();
        }        
        private bool ConfirmExit()
        {
            var result = MessageBox.Show
                (
                $"Вы нажали на кнопку выхода из программы.{Environment.NewLine}Подтверждаете выход?",
                "Подтверждение выхода из программы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            return result == DialogResult.Yes;
        }
    }
}
