using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinFormsApp
{
    public partial class RegistrationPanel : UserControl
    {
        public event EventHandler<User> RegistrationCompleted;
        private string lastName;
        private string firstName;
        private string patronymic = "";
        private User user;
        public RegistrationPanel()
        {
            InitializeComponent();
        }
        private bool RegistrateUser()
        {
            if (!InputValidator.CheckNameIsValid(lastName, out string lastNameErrorMessage))
            {
                lastNameErrorLabel.Text = lastNameErrorMessage;
                lastNameErrorLabel.Visible = true;
                return false;
            }
            if (!InputValidator.CheckNameIsValid(firstName, out string firstNameErrorMessage))
            {
                firstNameErrorLabel.Text = firstNameErrorMessage;
                firstNameErrorLabel.Visible = true;
                return false;
            }
            var hasPatronmyc = hasPatronymicCheckBox.Checked;
            if (hasPatronmyc)
            {
                if (!InputValidator.CheckNameIsValid(patronymic, out string patronmycErrorMessage))
                {
                    patronymicErrorLabel.Text = patronmycErrorMessage;
                    patronymicErrorLabel.Visible = true;
                    return false;
                }
            }
            var normalizedLastName = InputValidator.NormalizeName(lastName);
            var normalizedFirstName = InputValidator.NormalizeName(firstName);
            var normalizedPatronymic = InputValidator.NormalizeName(patronymic);
            if (!ConfirmName($"{normalizedFirstName} {normalizedLastName} {normalizedPatronymic}"))
            {
                return false;
            }
            user = new User(normalizedFirstName, normalizedLastName, normalizedPatronymic);
            return true;
        }
        private bool ConfirmName(string fullName)
        {
            DialogResult result = MessageBox.Show
                (
                $"Вы ввели {fullName}. Подтверждаешь ввод?",
                "Подтверждение ввода",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            return result == DialogResult.Yes;
        }
        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastName = lastNameTextBox.Text;
            if (!InputValidator.CheckNameIsValid(lastName, out string errorMessage))
            {
                lastNameErrorLabel.Text = errorMessage;
                lastNameErrorLabel.Visible = true;
            }
            else
            {
                lastNameErrorLabel.Visible = false;
            }
        }
        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            if (!InputValidator.CheckNameIsValid(firstName, out string errorMessage))
            {
                firstNameErrorLabel.Text = errorMessage;
                firstNameErrorLabel.Visible = true;
            }
            else
            {
                firstNameErrorLabel.Visible = false;
            }
        }
        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {
            patronymic = patronymicTextBox.Text;
            if (!InputValidator.CheckNameIsValid(patronymic, out string errorMessage))
            {
                patronymicErrorLabel.Text = errorMessage;
                patronymicErrorLabel.Visible = true;
            }
            else
            {
                patronymicErrorLabel.Visible = false;
            }
        }
        private void hasPatronymicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            patronymicTextBox.Enabled = hasPatronymicCheckBox.Checked;
            if (!hasPatronymicCheckBox.Checked)
            {
                patronymicTextBox.Text = "";
                patronymicErrorLabel.Visible = false;
            }
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!RegistrateUser())
            {
                return;
            }
            RegistrationCompleted?.Invoke(this, user);
        }
    }
}
