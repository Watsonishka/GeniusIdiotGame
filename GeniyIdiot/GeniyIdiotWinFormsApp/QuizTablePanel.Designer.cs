namespace GeniyIdiotWinFormsApp
{
    partial class QuizTablePanel
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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            quizTablePanel1 = new Panel();
            tableQuizListView = new ListView();
            columnHeader1 = new ColumnHeader();
            answersColumn = new ColumnHeader();
            diagnoseColumn = new ColumnHeader();
            nextButton = new Button();
            greetingsLabel = new Label();
            quizTablePanel1.SuspendLayout();
            SuspendLayout();
            // 
            // quizTablePanel1
            // 
            quizTablePanel1.Controls.Add(tableQuizListView);
            quizTablePanel1.Controls.Add(nextButton);
            quizTablePanel1.Controls.Add(greetingsLabel);
            quizTablePanel1.Location = new Point(-23, -14);
            quizTablePanel1.Name = "quizTablePanel1";
            quizTablePanel1.Size = new Size(966, 621);
            quizTablePanel1.TabIndex = 2;
            // 
            // tableQuizListView
            // 
            tableQuizListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, answersColumn, diagnoseColumn });
            tableQuizListView.Font = new Font("Segoe UI", 11F);
            tableQuizListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tableQuizListView.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            tableQuizListView.Location = new Point(83, 109);
            tableQuizListView.MultiSelect = false;
            tableQuizListView.Name = "tableQuizListView";
            tableQuizListView.ShowItemToolTips = true;
            tableQuizListView.Size = new Size(834, 388);
            tableQuizListView.TabIndex = 14;
            tableQuizListView.UseCompatibleStateImageBehavior = false;
            tableQuizListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ФИО";
            columnHeader1.Width = 603;
            // 
            // answersColumn
            // 
            answersColumn.Text = "Правильные ответы";
            answersColumn.TextAlign = HorizontalAlignment.Center;
            answersColumn.Width = 153;
            // 
            // diagnoseColumn
            // 
            diagnoseColumn.Text = "Диагноз";
            diagnoseColumn.TextAlign = HorizontalAlignment.Center;
            diagnoseColumn.Width = 70;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(394, 525);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(200, 45);
            nextButton.TabIndex = 13;
            nextButton.Text = "Назад";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // greetingsLabel
            // 
            greetingsLabel.AutoSize = true;
            greetingsLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            greetingsLabel.Location = new Point(369, 54);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(270, 25);
            greetingsLabel.TabIndex = 2;
            greetingsLabel.Text = "Результаты предыдущих игр:";
            // 
            // QuizTablePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(quizTablePanel1);
            Name = "QuizTablePanel";
            Size = new Size(920, 593);
            quizTablePanel1.ResumeLayout(false);
            quizTablePanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel quizTablePanel1;
        private Button nextButton;
        private Label greetingsLabel;
        private ListView tableQuizListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader answersColumn;
        private ColumnHeader diagnoseColumn;
    }
}
