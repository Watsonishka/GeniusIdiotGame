using GeniyIdiotClassLibrary;
namespace GeniyIdiotWinFormsApp
{
    public partial class QuizTablePanel : UserControl
    {
        public event EventHandler QuizTablePanelClosed;
        public QuizTablePanel()
        {
            InitializeComponent();
        }
        public void ShowTable()
        {
            tableQuizListView.Items.Clear();
            var quizResults = UserResultStorage.GetQuizHistory();
            foreach (var user in quizResults)
            {
                var tableLine = new ListViewItem(user.FullName);
                tableLine.SubItems.Add(user.RightAnswerCount.ToString());
                tableLine.SubItems.Add(user.Diagnose.Name);
                tableQuizListView.Items.Add(tableLine);
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            QuizTablePanelClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}
