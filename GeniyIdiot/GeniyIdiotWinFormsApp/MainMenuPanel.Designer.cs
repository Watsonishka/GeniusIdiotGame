namespace GeniyIdiotWinFormsApp
{
    partial class MainMenuPanel
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
            mainMenuPanel1 = new Panel();
            exitButton = new Button();
            deleteQuestionButton = new Button();
            addQuestionsButton = new Button();
            showQuizTableButton = new Button();
            startQuizButton = new Button();
            greetingsUserLabel = new Label();
            nameGameLabel = new Label();
            mainMenuPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuPanel1
            // 
            mainMenuPanel1.Controls.Add(exitButton);
            mainMenuPanel1.Controls.Add(deleteQuestionButton);
            mainMenuPanel1.Controls.Add(addQuestionsButton);
            mainMenuPanel1.Controls.Add(showQuizTableButton);
            mainMenuPanel1.Controls.Add(startQuizButton);
            mainMenuPanel1.Controls.Add(greetingsUserLabel);
            mainMenuPanel1.Controls.Add(nameGameLabel);
            mainMenuPanel1.Location = new Point(-37, -14);
            mainMenuPanel1.Name = "mainMenuPanel1";
            mainMenuPanel1.Size = new Size(966, 621);
            mainMenuPanel1.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(256, 487);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(480, 73);
            exitButton.TabIndex = 16;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // deleteQuestionButton
            // 
            deleteQuestionButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteQuestionButton.Location = new Point(256, 408);
            deleteQuestionButton.Name = "deleteQuestionButton";
            deleteQuestionButton.Size = new Size(480, 73);
            deleteQuestionButton.TabIndex = 15;
            deleteQuestionButton.Text = "Удалить вопрос";
            deleteQuestionButton.UseVisualStyleBackColor = true;
            deleteQuestionButton.Click += deleteQuestionButton_Click;
            // 
            // addQuestionsButton
            // 
            addQuestionsButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addQuestionsButton.Location = new Point(256, 329);
            addQuestionsButton.Name = "addQuestionsButton";
            addQuestionsButton.Size = new Size(480, 73);
            addQuestionsButton.TabIndex = 14;
            addQuestionsButton.Text = "Добавить вопрос";
            addQuestionsButton.UseVisualStyleBackColor = true;
            addQuestionsButton.Click += addQuestionsButton_Click;
            // 
            // showQuizTableButton
            // 
            showQuizTableButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showQuizTableButton.Location = new Point(256, 250);
            showQuizTableButton.Name = "showQuizTableButton";
            showQuizTableButton.Size = new Size(480, 73);
            showQuizTableButton.TabIndex = 13;
            showQuizTableButton.Text = "Показать предыдущие результаты игры";
            showQuizTableButton.UseVisualStyleBackColor = true;
            showQuizTableButton.Click += showQuizTableButton_Click;
            // 
            // startQuizButton
            // 
            startQuizButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startQuizButton.Location = new Point(256, 171);
            startQuizButton.Name = "startQuizButton";
            startQuizButton.Size = new Size(480, 73);
            startQuizButton.TabIndex = 12;
            startQuizButton.Text = "Начать игру";
            startQuizButton.UseVisualStyleBackColor = true;
            startQuizButton.Click += startQuizButton_Click;
            // 
            // greetingsUserLabel
            // 
            greetingsUserLabel.Font = new Font("Segoe UI", 14F);
            greetingsUserLabel.Location = new Point(77, 97);
            greetingsUserLabel.Name = "greetingsUserLabel";
            greetingsUserLabel.Size = new Size(852, 71);
            greetingsUserLabel.TabIndex = 2;
            greetingsUserLabel.Text = "Приветстую тебя, ФИО!";
            greetingsUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameGameLabel
            // 
            nameGameLabel.AutoSize = true;
            nameGameLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            nameGameLabel.Location = new Point(317, 52);
            nameGameLabel.Name = "nameGameLabel";
            nameGameLabel.Size = new Size(344, 45);
            nameGameLabel.TabIndex = 0;
            nameGameLabel.Text = "Игра \"Гений - Идиот\"";
            // 
            // MainMenuPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainMenuPanel1);
            Name = "MainMenuPanel";
            Size = new Size(892, 593);
            mainMenuPanel1.ResumeLayout(false);
            mainMenuPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainMenuPanel1;
        private Button startQuizButton;
        private Label greetingsUserLabel;
        private Label nameGameLabel;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button showQuizTableButton;
        private Button addQuestionsButton;
        private Button deleteQuestionButton;
        private Button exitButton;
    }
}
