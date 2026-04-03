using GeniyIdiotClassLibrary;
namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionPanel : UserControl
    {
        public event EventHandler AddQuestionsPanelClosed;
        private string questionMessageInput;
        private int answerInput;
        public AddQuestionPanel()
        {
            InitializeComponent();
            rulesQuestionLabel.Text = $"Правила составления:{Environment.NewLine}1. Вопрос должен быть сформулирован в повествовательно-вопросительной форме " +
                $"(заканчиваться вопросительным знаком) на РУССКОМ языке.{Environment.NewLine}2. Ответом на вопрос должно быть целое " +
                $"число.{Environment.NewLine}3. Соблюдай правила русского языка, логику и здравый смысл, а также старайся не делать опечатки!";

            rulesAnswerLabel.Text = $"Ответом на вопрос должно быть целое число!{Environment.NewLine}Пожалуйста, не" +
                $" забывай о логике и здравом смысле!";
        }
        public void CleanTextBoxes()
        {
            userQuestionMessageTextBox.Clear();
            userRightAnswerTextBox.Clear();
            errorQuestionMessageLabel.Visible = false;
            errorAnswerLabel.Visible = false;
        }
        private void userQuestionMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            questionMessageInput = userQuestionMessageTextBox.Text;
            if (!InputValidator.CheckSentenceIsValid(questionMessageInput, out string errorMessage))
            {
                errorQuestionMessageLabel.Text = errorMessage;
                errorQuestionMessageLabel.Visible = true;
            }
            else
            {
                errorQuestionMessageLabel.Visible = false;
            }
        }
        private void userRightAnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                answerInput = Convert.ToInt32(userRightAnswerTextBox.Text);
                errorAnswerLabel.Visible = false;
            }
            catch
            {
                errorAnswerLabel.Visible = true;
                errorAnswerLabel.Text = $"Некорректный ввод. Нужно ввести целое число от {int.MinValue} до {int.MaxValue}. Попробуйте снова!";
            }
        }
        private bool RegistrateQuestion()
        {
            if (!InputValidator.CheckSentenceIsValid(questionMessageInput, out string errorMessage))
            {
                errorQuestionMessageLabel.Text = errorMessage;
                errorQuestionMessageLabel.Visible = true;
                return false;
            }
            if (!int.TryParse(userRightAnswerTextBox.Text, out answerInput))
            {
                errorAnswerLabel.Visible = true;
                errorAnswerLabel.Text = "Некорректный ввод. Нужно ввести целое число.";
                return false;
            }
            return true;
        }
        private bool ConfirmInputQuestion()
        {
            var result = MessageBox.Show
                (
                $"Вы ввели вопрос:{Environment.NewLine}" +
                $"{InputValidator.NormalizeQuestion(questionMessageInput.TrimEnd('?'))}. {Environment.NewLine}" +
                $"Вы ввели ответ:{Environment.NewLine}" +
                $"{answerInput}{Environment.NewLine}" +
                $"Подтверждаешь ввод?",
                "Подтверждение ввода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            return result == DialogResult.Yes;
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!RegistrateQuestion())
            {
                return;
            }
            if (!ConfirmInputQuestion())
            {
                return;
            }
            var questions = QuestionStorage.GetAll();
            var question = new Question(InputValidator.NormalizeQuestion(questionMessageInput.TrimEnd('?')), Convert.ToInt32(userRightAnswerTextBox.Text));
            questions.Add(question);
            QuestionStorage.RewriteFile(questions);
            MessageBox.Show($"Твой вопрос успешно добавлен!{Environment.NewLine}Ты сможешь удалить его позднее!");
            CleanTextBoxes();
        }
        private void previousButton_Click(object sender, EventArgs e)
        {
            AddQuestionsPanelClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
