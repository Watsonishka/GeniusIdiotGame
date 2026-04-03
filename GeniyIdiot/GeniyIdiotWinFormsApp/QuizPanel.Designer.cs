namespace GeniyIdiotWinFormsApp
{
    partial class QuizPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLeftProgressBar = new ProgressBar();
            quizPanel1 = new Panel();
            leftTimeLabel = new Label();
            errorMessageLabel = new Label();
            userAnswerTextBox = new TextBox();
            acceptAnswerLabel = new Label();
            questionMessageLabel = new Label();
            nextButton = new Button();
            questionNumberLabel = new Label();
            greetingsLabel = new Label();
            roundTimer = new System.Windows.Forms.Timer(components);
            quizPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // timeLeftProgressBar
            // 
            timeLeftProgressBar.Location = new Point(329, 296);
            timeLeftProgressBar.Maximum = 15;
            timeLeftProgressBar.Name = "timeLeftProgressBar";
            timeLeftProgressBar.Size = new Size(281, 23);
            timeLeftProgressBar.Style = ProgressBarStyle.Continuous;
            timeLeftProgressBar.TabIndex = 18;
            timeLeftProgressBar.Value = 15;
            // 
            // quizPanel1
            // 
            quizPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quizPanel1.Controls.Add(leftTimeLabel);
            quizPanel1.Controls.Add(timeLeftProgressBar);
            quizPanel1.Controls.Add(errorMessageLabel);
            quizPanel1.Controls.Add(userAnswerTextBox);
            quizPanel1.Controls.Add(acceptAnswerLabel);
            quizPanel1.Controls.Add(questionMessageLabel);
            quizPanel1.Controls.Add(nextButton);
            quizPanel1.Controls.Add(questionNumberLabel);
            quizPanel1.Controls.Add(greetingsLabel);
            quizPanel1.Location = new Point(-39, -22);
            quizPanel1.Name = "quizPanel1";
            quizPanel1.Size = new Size(924, 595);
            quizPanel1.TabIndex = 2;
            // 
            // leftTimeLabel
            // 
            leftTimeLabel.AutoSize = true;
            leftTimeLabel.Font = new Font("Segoe UI", 14F);
            leftTimeLabel.Location = new Point(386, 257);
            leftTimeLabel.Name = "leftTimeLabel";
            leftTimeLabel.Size = new Size(178, 25);
            leftTimeLabel.TabIndex = 19;
            leftTimeLabel.Text = "Осталось времени:";
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.Font = new Font("Segoe UI", 12F);
            errorMessageLabel.ForeColor = Color.Brown;
            errorMessageLabel.Location = new Point(94, 398);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(69, 21);
            errorMessageLabel.TabIndex = 17;
            errorMessageLabel.Text = "Ошибка";
            errorMessageLabel.Visible = false;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(94, 372);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(790, 23);
            userAnswerTextBox.TabIndex = 16;
            userAnswerTextBox.TextChanged += userAnswerTextBox_TextChanged_1;
            // 
            // acceptAnswerLabel
            // 
            acceptAnswerLabel.AutoSize = true;
            acceptAnswerLabel.Font = new Font("Segoe UI", 14F);
            acceptAnswerLabel.Location = new Point(417, 335);
            acceptAnswerLabel.Name = "acceptAnswerLabel";
            acceptAnswerLabel.Size = new Size(110, 25);
            acceptAnswerLabel.TabIndex = 15;
            acceptAnswerLabel.Text = "Твой ответ:";
            // 
            // questionMessageLabel
            // 
            questionMessageLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            questionMessageLabel.Location = new Point(94, 143);
            questionMessageLabel.Name = "questionMessageLabel";
            questionMessageLabel.Size = new Size(790, 93);
            questionMessageLabel.TabIndex = 14;
            questionMessageLabel.Text = "Текст вопроса";
            questionMessageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(329, 452);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(281, 73);
            nextButton.TabIndex = 13;
            nextButton.Text = "Ответить досрочно";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Segoe UI", 14F);
            questionNumberLabel.Location = new Point(417, 118);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(116, 25);
            questionNumberLabel.TabIndex = 2;
            questionNumberLabel.Text = "Вопрос №0:";
            // 
            // greetingsLabel
            // 
            greetingsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            greetingsLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            greetingsLabel.Location = new Point(118, 40);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(748, 44);
            greetingsLabel.TabIndex = 0;
            greetingsLabel.Text = "Привет, ФИО!";
            greetingsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundTimer
            // 
            roundTimer.Interval = 1000;
            roundTimer.Tick += roundTimer_Tick;
            // 
            // QuizPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(quizPanel1);
            Name = "QuizPanel";
            Size = new Size(888, 576);
            quizPanel1.ResumeLayout(false);
            quizPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel quizPanel1;
        private Button nextButton;
        private Label greetingsLabel;
        private Label questionNumberLabel;
        private Label questionMessageLabel;
        private Label acceptAnswerLabel;
        private TextBox userAnswerTextBox;
        private Label errorMessageLabel;
        private System.Windows.Forms.Timer roundTimer;
        private Label leftTimeLabel;
        private ProgressBar timeLeftProgressBar;
    }
}
