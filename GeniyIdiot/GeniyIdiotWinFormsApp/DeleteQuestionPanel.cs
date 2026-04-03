using GeniyIdiotClassLibrary;
using Newtonsoft.Json;
namespace GeniyIdiotWinFormsApp
{
    public partial class DeleteQuestionPanel : UserControl
    {
        public event EventHandler DeleteQuestionsPanelClosed;
        private List<Question> questions;
        private int deleteQuestionIndex;
        public DeleteQuestionPanel()
        {
            InitializeComponent();
            deleteButton.Enabled = false;
        }
        public void RefreshQuestionsList()
        {
            questions = QuestionStorage.GetAll();
        }
        public void ShowTable()
        {
            avalableQuestionDataGridView.Rows.Clear();
            if (questions.Count == 5)
            {
                ShowDeleteListEmptyMessage();
                return;
            }
            for (var i = 5; i < questions.Count; i++)
            {
                avalableQuestionDataGridView.Rows.Add
                    (
                    i,
                    questions[i].Message
                    );
            }
        }
        public void ShowDeleteListEmptyMessage()
        {
            MessageBox.Show($"Отсутвуют доступные вопросы для удаления!{Environment.NewLine}Приходи, когда добавишь свои собственные вопросы! :)");
        }
        private void DeleteQuestion()
        {
            if (!ConfirmInputQuestion())
            {
                return;
            }
            questions.RemoveAt(deleteQuestionIndex);
            ShowTable();
        }
        private bool ConfirmInputQuestion()
        {
            var result = MessageBox.Show
                (
                $"Вы выбрали вопрос для удаления:{Environment.NewLine}" +
                $"{questions[deleteQuestionIndex].Message}{Environment.NewLine}" +
                $"Подтверждаешь удаления этого вопроса?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            return result == DialogResult.Yes;
        }
        private void previousButton_Click(object sender, EventArgs e)
        {   var jsonData = JsonConvert.SerializeObject(questions);
            QuestionStorage.RewriteFile(questions);

            DeleteQuestionsPanelClosed?.Invoke(this, EventArgs.Empty);
        }
        private void avalableQuestionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var selectedValue = avalableQuestionDataGridView.Rows[e.RowIndex].Cells[0].Value;
            if (selectedValue != null)
            {
                deleteButton.Enabled = true;
                deleteQuestionIndex = Convert.ToInt32(selectedValue);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (questions.Count == 5)
            {
                avalableQuestionDataGridView.ClearSelection();
                return;
            }
            else
            {
                DeleteQuestion();
                avalableQuestionDataGridView.ClearSelection();
                deleteButton.Enabled = false;
            }
        }
    }
}
