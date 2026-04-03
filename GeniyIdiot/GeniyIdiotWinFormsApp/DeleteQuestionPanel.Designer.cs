namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionPanel
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            deleteQuestiomTablePanel1 = new Panel();
            avalableQuestionDataGridView = new DataGridView();
            questionIndex = new DataGridViewTextBoxColumn();
            uestionMessage = new DataGridViewTextBoxColumn();
            deleteButton = new Button();
            rulesLabel = new Label();
            previousButton = new Button();
            greetingsLabel = new Label();
            deleteQuestiomTablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avalableQuestionDataGridView).BeginInit();
            SuspendLayout();
            // 
            // deleteQuestiomTablePanel1
            // 
            deleteQuestiomTablePanel1.Controls.Add(avalableQuestionDataGridView);
            deleteQuestiomTablePanel1.Controls.Add(deleteButton);
            deleteQuestiomTablePanel1.Controls.Add(rulesLabel);
            deleteQuestiomTablePanel1.Controls.Add(previousButton);
            deleteQuestiomTablePanel1.Controls.Add(greetingsLabel);
            deleteQuestiomTablePanel1.Location = new Point(3, 1);
            deleteQuestiomTablePanel1.Name = "deleteQuestiomTablePanel1";
            deleteQuestiomTablePanel1.Size = new Size(966, 621);
            deleteQuestiomTablePanel1.TabIndex = 3;
            // 
            // avalableQuestionDataGridView
            // 
            avalableQuestionDataGridView.AllowUserToAddRows = false;
            avalableQuestionDataGridView.BackgroundColor = SystemColors.ButtonHighlight;
            avalableQuestionDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            avalableQuestionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            avalableQuestionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            avalableQuestionDataGridView.Columns.AddRange(new DataGridViewColumn[] { questionIndex, uestionMessage });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.MenuText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            avalableQuestionDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            avalableQuestionDataGridView.EnableHeadersVisualStyles = false;
            avalableQuestionDataGridView.GridColor = SystemColors.Desktop;
            avalableQuestionDataGridView.Location = new Point(77, 83);
            avalableQuestionDataGridView.MultiSelect = false;
            avalableQuestionDataGridView.Name = "avalableQuestionDataGridView";
            avalableQuestionDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            avalableQuestionDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            avalableQuestionDataGridView.RowHeadersVisible = false;
            avalableQuestionDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            avalableQuestionDataGridView.Size = new Size(833, 340);
            avalableQuestionDataGridView.TabIndex = 17;
            avalableQuestionDataGridView.CellClick += avalableQuestionDataGridView_CellClick;
            // 
            // questionIndex
            // 
            questionIndex.HeaderText = "Индекс вопроса";
            questionIndex.Name = "questionIndex";
            questionIndex.ReadOnly = true;
            // 
            // uestionMessage
            // 
            uestionMessage.FillWeight = 750F;
            uestionMessage.HeaderText = "Вопрос";
            uestionMessage.Name = "uestionMessage";
            uestionMessage.ReadOnly = true;
            uestionMessage.Width = 750;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteButton.Location = new Point(264, 499);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(200, 45);
            deleteButton.TabIndex = 16;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // rulesLabel
            // 
            rulesLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            rulesLabel.Location = new Point(216, 447);
            rulesLabel.Name = "rulesLabel";
            rulesLabel.Size = new Size(724, 49);
            rulesLabel.TabIndex = 15;
            rulesLabel.Text = "Выбери вопрос, который хочешь удалить (кнопка \"Удалить\" станет активной).";
            // 
            // previousButton
            // 
            previousButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            previousButton.Location = new Point(531, 499);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(200, 45);
            previousButton.TabIndex = 13;
            previousButton.Text = "Назад";
            previousButton.UseVisualStyleBackColor = true;
            previousButton.Click += previousButton_Click;
            // 
            // greetingsLabel
            // 
            greetingsLabel.AutoSize = true;
            greetingsLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            greetingsLabel.Location = new Point(328, 36);
            greetingsLabel.Name = "greetingsLabel";
            greetingsLabel.Size = new Size(325, 25);
            greetingsLabel.TabIndex = 2;
            greetingsLabel.Text = "Вопросы, доступные для удаления:";
            // 
            // DeleteQuestionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteQuestiomTablePanel1);
            Name = "DeleteQuestionPanel";
            Size = new Size(990, 622);
            deleteQuestiomTablePanel1.ResumeLayout(false);
            deleteQuestiomTablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avalableQuestionDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel deleteQuestiomTablePanel1;
        private ColumnHeader columnHeader1;
        private ColumnHeader answersColumn;
        private Button previousButton;
        private Label greetingsLabel;
        private Label rulesLabel;
        private Button deleteButton;
        private DataGridView avalableQuestionDataGridView;
        private DataGridViewTextBoxColumn questionIndex;
        private DataGridViewTextBoxColumn uestionMessage;
    }
}
