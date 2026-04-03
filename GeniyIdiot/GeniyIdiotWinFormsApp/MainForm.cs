using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private RegistrationPanel registrationPanel;
        private MainMenuPanel mainMenuPanel;
        private QuizPanel quizPanel;
        private QuizTablePanel quizTablePanel;
        private AddQuestionPanel addQuestionsPanel;
        private DeleteQuestionPanel deleteQuestionsPanel;

        public MainForm()
        {
            InitializeComponent();

            registrationPanel = new RegistrationPanel();
            Controls.Add(registrationPanel);
            registrationPanel.RegistrationCompleted += RegistrationCompleted;

            mainMenuPanel = new MainMenuPanel();
            mainMenuPanel.QuizSessionRequested += QuizSessionRequested;
            mainMenuPanel.QuizTableShowRequested += QuizTableShowRequested;
            mainMenuPanel.AddQuestionsRequested += AddQuestionsRequested;
            mainMenuPanel.DeleteQuestionsRequested += DeleteQuestionsRequested;

            quizPanel = new QuizPanel();
            quizPanel.QuizFinished += QuizFinished;

            quizTablePanel = new QuizTablePanel();
            quizTablePanel.QuizTablePanelClosed += QuizTablePanelClosed;

            addQuestionsPanel = new AddQuestionPanel();
            addQuestionsPanel.AddQuestionsPanelClosed += AddQuestionsPanelClosed;

            deleteQuestionsPanel = new DeleteQuestionPanel();
            deleteQuestionsPanel.DeleteQuestionsPanelClosed += DeleteQuestionsPanelClosed;
        }
        private void RegistrationCompleted(object sender, User userFIO)
        {
            Controls.Remove(registrationPanel);
            mainMenuPanel.User = userFIO;
            Controls.Add(mainMenuPanel);
        }
        private void QuizSessionRequested(object sender, User userFIO)
        {
            Controls.Remove(mainMenuPanel);
            quizPanel.User = userFIO;
            quizPanel.ResetQuiz();
            Controls.Add(quizPanel);
        }
        private void QuizFinished(object sender, System.EventArgs e)
        {
            Controls.Remove(quizPanel);
            Controls.Add(mainMenuPanel);
        }
        private void QuizTableShowRequested(object sender, System.EventArgs e)
        {
            Controls.Remove(mainMenuPanel);
            quizTablePanel.ShowTable();
            Controls.Add(quizTablePanel);
        }
        private void QuizTablePanelClosed(object sender, System.EventArgs e)
        {
            Controls.Remove(quizTablePanel);
            Controls.Add(mainMenuPanel);
        }
        private void AddQuestionsRequested(object sender, System.EventArgs e)
        {
            Controls.Remove(mainMenuPanel);
            addQuestionsPanel.CleanTextBoxes();
            Controls.Add(addQuestionsPanel);
        }
        private void AddQuestionsPanelClosed(object sender, System.EventArgs e)
        {
            Controls.Remove(addQuestionsPanel);
            Controls.Add(mainMenuPanel);
        }
        private void DeleteQuestionsRequested(object sender, System.EventArgs e)
        {
            var questions = QuestionStorage.GetAll();
            if (questions.Count == 5)
            {
                deleteQuestionsPanel.ShowDeleteListEmptyMessage();
                Controls.Add(mainMenuPanel);
            }
            else
            {
                Controls.Remove(mainMenuPanel);
                deleteQuestionsPanel.RefreshQuestionsList();
                deleteQuestionsPanel.ShowTable();
                Controls.Add(deleteQuestionsPanel);
            }
        }
        private void DeleteQuestionsPanelClosed(object sender, System.EventArgs e)
        {
            Controls.Remove(deleteQuestionsPanel);
            Controls.Add(mainMenuPanel);
        }
    }
}
