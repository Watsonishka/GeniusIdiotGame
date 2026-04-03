namespace GeniyIdiotWinFormsApp
{
    partial class RegistrationPanel
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
            registarationPanel1 = new Panel();
            nextButton = new Button();
            hasPatronymicCheckBox = new CheckBox();
            patronymicErrorLabel = new Label();
            patronymicTextBox = new TextBox();
            patronymicLabel = new Label();
            firstNameErrorLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameErrorLabel = new Label();
            lastNameTextBox = new TextBox();
            rulesLabel = new Label();
            lastNameLabel = new Label();
            nameGameLabel = new Label();
            registarationPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // registarationPanel1
            // 
            registarationPanel1.Controls.Add(nextButton);
            registarationPanel1.Controls.Add(hasPatronymicCheckBox);
            registarationPanel1.Controls.Add(patronymicErrorLabel);
            registarationPanel1.Controls.Add(patronymicTextBox);
            registarationPanel1.Controls.Add(patronymicLabel);
            registarationPanel1.Controls.Add(firstNameErrorLabel);
            registarationPanel1.Controls.Add(firstNameTextBox);
            registarationPanel1.Controls.Add(firstNameLabel);
            registarationPanel1.Controls.Add(lastNameErrorLabel);
            registarationPanel1.Controls.Add(lastNameTextBox);
            registarationPanel1.Controls.Add(rulesLabel);
            registarationPanel1.Controls.Add(lastNameLabel);
            registarationPanel1.Controls.Add(nameGameLabel);
            registarationPanel1.Location = new Point(3, 3);
            registarationPanel1.Name = "registarationPanel1";
            registarationPanel1.Size = new Size(966, 621);
            registarationPanel1.TabIndex = 0;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(338, 470);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(292, 73);
            nextButton.TabIndex = 12;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // hasPatronymicCheckBox
            // 
            hasPatronymicCheckBox.AutoSize = true;
            hasPatronymicCheckBox.Checked = true;
            hasPatronymicCheckBox.CheckState = CheckState.Checked;
            hasPatronymicCheckBox.Font = new Font("Segoe UI", 14F);
            hasPatronymicCheckBox.Location = new Point(209, 402);
            hasPatronymicCheckBox.Name = "hasPatronymicCheckBox";
            hasPatronymicCheckBox.Size = new Size(151, 29);
            hasPatronymicCheckBox.TabIndex = 11;
            hasPatronymicCheckBox.Text = "Есть отчество";
            hasPatronymicCheckBox.UseVisualStyleBackColor = true;
            hasPatronymicCheckBox.CheckedChanged += hasPatronymicCheckBox_CheckedChanged;
            // 
            // patronymicErrorLabel
            // 
            patronymicErrorLabel.AutoSize = true;
            patronymicErrorLabel.Font = new Font("Segoe UI", 11F);
            patronymicErrorLabel.ForeColor = Color.Brown;
            patronymicErrorLabel.Location = new Point(204, 369);
            patronymicErrorLabel.Name = "patronymicErrorLabel";
            patronymicErrorLabel.Size = new Size(65, 20);
            patronymicErrorLabel.TabIndex = 10;
            patronymicErrorLabel.Text = "Ошибка";
            patronymicErrorLabel.Visible = false;
            // 
            // patronymicTextBox
            // 
            patronymicTextBox.Location = new Point(204, 343);
            patronymicTextBox.Name = "patronymicTextBox";
            patronymicTextBox.Size = new Size(674, 23);
            patronymicTextBox.TabIndex = 9;
            patronymicTextBox.TextChanged += patronymicTextBox_TextChanged;
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Font = new Font("Segoe UI", 14.25F);
            patronymicLabel.Location = new Point(82, 343);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new Size(93, 25);
            patronymicLabel.TabIndex = 8;
            patronymicLabel.Text = "Отчество";
            // 
            // firstNameErrorLabel
            // 
            firstNameErrorLabel.AutoSize = true;
            firstNameErrorLabel.Font = new Font("Segoe UI", 11F);
            firstNameErrorLabel.ForeColor = Color.Brown;
            firstNameErrorLabel.Location = new Point(204, 304);
            firstNameErrorLabel.Name = "firstNameErrorLabel";
            firstNameErrorLabel.Size = new Size(65, 20);
            firstNameErrorLabel.TabIndex = 7;
            firstNameErrorLabel.Text = "Ошибка";
            firstNameErrorLabel.Visible = false;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(204, 278);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(674, 23);
            firstNameTextBox.TabIndex = 6;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 14.25F);
            firstNameLabel.Location = new Point(126, 278);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(49, 25);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "Имя";
            // 
            // lastNameErrorLabel
            // 
            lastNameErrorLabel.AutoSize = true;
            lastNameErrorLabel.Font = new Font("Segoe UI", 11F);
            lastNameErrorLabel.ForeColor = Color.Brown;
            lastNameErrorLabel.Location = new Point(204, 235);
            lastNameErrorLabel.Name = "lastNameErrorLabel";
            lastNameErrorLabel.Size = new Size(65, 20);
            lastNameErrorLabel.TabIndex = 4;
            lastNameErrorLabel.Text = "Ошибка";
            lastNameErrorLabel.Visible = false;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(204, 209);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(674, 23);
            lastNameTextBox.TabIndex = 3;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // rulesLabel
            // 
            rulesLabel.AutoSize = true;
            rulesLabel.Font = new Font("Segoe UI", 14F);
            rulesLabel.Location = new Point(416, 143);
            rulesLabel.Name = "rulesLabel";
            rulesLabel.Size = new Size(160, 25);
            rulesLabel.TabIndex = 2;
            rulesLabel.Text = "Введи свое ФИО:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 14.25F);
            lastNameLabel.Location = new Point(84, 207);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(91, 25);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Фамилия";
            // 
            // nameGameLabel
            // 
            nameGameLabel.AutoSize = true;
            nameGameLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            nameGameLabel.Location = new Point(178, 53);
            nameGameLabel.Name = "nameGameLabel";
            nameGameLabel.Size = new Size(673, 45);
            nameGameLabel.TabIndex = 0;
            nameGameLabel.Text = "Добро пожаловать в игру \"Гений - Идиот\"!";
            // 
            // RegistrationPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(registarationPanel1);
            Name = "RegistrationPanel";
            Size = new Size(972, 627);
            registarationPanel1.ResumeLayout(false);
            registarationPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel registarationPanel1;
        private Label nameGameLabel;
        private Label rulesLabel;
        private Label lastNameLabel;
        private Label lastNameErrorLabel;
        private TextBox lastNameTextBox;
        private Label firstNameErrorLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label patronymicErrorLabel;
        private TextBox patronymicTextBox;
        private Label patronymicLabel;
        private CheckBox hasPatronymicCheckBox;
        private Button nextButton;
    }
}
