namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionPanel
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
            addQuestionPanel1 = new Panel();
            previousButton = new Button();
            rulesAnswerLabel = new Label();
            userQuestionMessageTextBox = new TextBox();
            errorAnswerLabel = new Label();
            userRightAnswerTextBox = new TextBox();
            ruleAnswerLabel = new Label();
            errorQuestionMessageLabel = new Label();
            rulesQuestionLabel = new Label();
            nextButton = new Button();
            rulesMessageLabel = new Label();
            addQuestionPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // addQuestionPanel1
            // 
            addQuestionPanel1.Controls.Add(previousButton);
            addQuestionPanel1.Controls.Add(rulesAnswerLabel);
            addQuestionPanel1.Controls.Add(userQuestionMessageTextBox);
            addQuestionPanel1.Controls.Add(errorAnswerLabel);
            addQuestionPanel1.Controls.Add(userRightAnswerTextBox);
            addQuestionPanel1.Controls.Add(ruleAnswerLabel);
            addQuestionPanel1.Controls.Add(errorQuestionMessageLabel);
            addQuestionPanel1.Controls.Add(rulesQuestionLabel);
            addQuestionPanel1.Controls.Add(nextButton);
            addQuestionPanel1.Controls.Add(rulesMessageLabel);
            addQuestionPanel1.Location = new Point(-5, -13);
            addQuestionPanel1.Name = "addQuestionPanel1";
            addQuestionPanel1.Size = new Size(966, 621);
            addQuestionPanel1.TabIndex = 3;
            // 
            // previousButton
            // 
            previousButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            previousButton.Location = new Point(499, 492);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(233, 50);
            previousButton.TabIndex = 24;
            previousButton.Text = "Назад";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // rulesAnswerLabel
            // 
            rulesAnswerLabel.Font = new Font("Segoe UI", 10.25F);
            rulesAnswerLabel.Location = new Point(93, 360);
            rulesAnswerLabel.Name = "rulesAnswerLabel";
            rulesAnswerLabel.Size = new Size(790, 60);
            rulesAnswerLabel.TabIndex = 23;
            rulesAnswerLabel.Text = "Правила";
            rulesAnswerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userQuestionMessageTextBox
            // 
            userQuestionMessageTextBox.Location = new Point(93, 214);
            userQuestionMessageTextBox.Multiline = true;
            userQuestionMessageTextBox.Name = "userQuestionMessageTextBox";
            userQuestionMessageTextBox.Size = new Size(790, 66);
            userQuestionMessageTextBox.TabIndex = 22;
            userQuestionMessageTextBox.TextChanged += userQuestionMessageTextBox_TextChanged;
            // 
            // errorAnswerLabel
            // 
            errorAnswerLabel.AutoSize = true;
            errorAnswerLabel.Font = new Font("Segoe UI", 12F);
            errorAnswerLabel.ForeColor = Color.Brown;
            errorAnswerLabel.Location = new Point(93, 451);
            errorAnswerLabel.Name = "errorAnswerLabel";
            errorAnswerLabel.Size = new Size(69, 21);
            errorAnswerLabel.TabIndex = 21;
            errorAnswerLabel.Text = "Ошибка";
            errorAnswerLabel.Visible = false;
            // 
            // userRightAnswerTextBox
            // 
            userRightAnswerTextBox.Location = new Point(93, 423);
            userRightAnswerTextBox.Multiline = true;
            userRightAnswerTextBox.Name = "userRightAnswerTextBox";
            userRightAnswerTextBox.Size = new Size(790, 25);
            userRightAnswerTextBox.TabIndex = 20;
            userRightAnswerTextBox.TextChanged += userRightAnswerTextBox_TextChanged;
            // 
            // ruleAnswerLabel
            // 
            ruleAnswerLabel.AutoSize = true;
            ruleAnswerLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ruleAnswerLabel.Location = new Point(387, 323);
            ruleAnswerLabel.Name = "ruleAnswerLabel";
            ruleAnswerLabel.Size = new Size(185, 25);
            ruleAnswerLabel.TabIndex = 18;
            ruleAnswerLabel.Text = "Добавь свой ответ!";
            // 
            // errorQuestionMessageLabel
            // 
            errorQuestionMessageLabel.AutoSize = true;
            errorQuestionMessageLabel.Font = new Font("Segoe UI", 12F);
            errorQuestionMessageLabel.ForeColor = Color.Brown;
            errorQuestionMessageLabel.Location = new Point(93, 283);
            errorQuestionMessageLabel.Name = "errorQuestionMessageLabel";
            errorQuestionMessageLabel.Size = new Size(69, 21);
            errorQuestionMessageLabel.TabIndex = 17;
            errorQuestionMessageLabel.Text = "Ошибка";
            errorQuestionMessageLabel.Visible = false;
            // 
            // rulesQuestionLabel
            // 
            rulesQuestionLabel.Font = new Font("Segoe UI", 10.25F);
            rulesQuestionLabel.Location = new Point(93, 91);
            rulesQuestionLabel.Name = "rulesQuestionLabel";
            rulesQuestionLabel.Size = new Size(790, 120);
            rulesQuestionLabel.TabIndex = 14;
            rulesQuestionLabel.Text = "Правила";
            rulesQuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(224, 492);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(233, 50);
            nextButton.TabIndex = 13;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // rulesMessageLabel
            // 
            rulesMessageLabel.AutoSize = true;
            rulesMessageLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rulesMessageLabel.Location = new Point(387, 57);
            rulesMessageLabel.Name = "rulesMessageLabel";
            rulesMessageLabel.Size = new Size(201, 25);
            rulesMessageLabel.TabIndex = 2;
            rulesMessageLabel.Text = "Добавь свой вопрос!";
            // 
            // AddQuestionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addQuestionPanel1);
            Name = "AddQuestionPanel";
            Size = new Size(957, 595);
            addQuestionPanel1.ResumeLayout(false);
            addQuestionPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addQuestionPanel1;
        private Label errorQuestionMessageLabel;
        private TextBox userAnswerTextBox;
        private Label acceptAnswerLabel;
        private Label rulesQuestionLabel;
        private Button nextButton;
        private Label rulesMessageLabel;
        private Label errorAnswerLabel;
        private TextBox userRightAnswerTextBox;
        private Label label2;
        private Label ruleAnswerLabel;
        private TextBox userQuestionMessageTextBox;
        private Label rulesAnswerLabel;
        private Button previousButton;
    }
}
