namespace GeniyIdiotWinFormsApp
{
    partial class QuestionsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionsDataGridView = new DataGridView();
            deleteButton = new Button();
            questionLabel = new Label();
            questionTextBox = new TextBox();
            answerLabel = new Label();
            answerTextBox = new TextBox();
            addButton = new Button();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            questionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Location = new Point(20, 17);
            questionsDataGridView.Margin = new Padding(2, 2, 2, 2);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 62;
            questionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questionsDataGridView.Size = new Size(574, 201);
            questionsDataGridView.TabIndex = 0;
            questionsDataGridView.KeyDown += questionsDataGridView_KeyDown;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteButton.BackColor = Color.FromArgb(255, 192, 192);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(20, 238);
            deleteButton.Margin = new Padding(2, 2, 2, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(136, 36);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Удалить вопрос";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // questionLabel
            // 
            questionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(21, 289);
            questionLabel.Margin = new Padding(2, 0, 2, 0);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(85, 15);
            questionLabel.TabIndex = 2;
            questionLabel.Text = "Текст вопроса";
            // 
            // questionTextBox
            // 
            questionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            questionTextBox.Location = new Point(125, 290);
            questionTextBox.Margin = new Padding(2, 2, 2, 2);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(470, 23);
            questionTextBox.TabIndex = 3;
            // 
            // answerLabel
            // 
            answerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            answerLabel.AutoSize = true;
            answerLabel.Location = new Point(21, 316);
            answerLabel.Margin = new Padding(2, 0, 2, 0);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new Size(38, 15);
            answerLabel.TabIndex = 2;
            answerLabel.Text = "Ответ";
            // 
            // answerTextBox
            // 
            answerTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            answerTextBox.Location = new Point(125, 317);
            answerTextBox.Margin = new Padding(2, 2, 2, 2);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(470, 23);
            answerTextBox.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.BackColor = Color.FromArgb(192, 255, 192);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(179, 238);
            addButton.Margin = new Padding(2, 2, 2, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(136, 36);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить вопрос";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.BackColor = SystemColors.Control;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Location = new Point(458, 356);
            closeButton.Margin = new Padding(2, 2, 2, 2);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(136, 34);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(617, 403);
            Controls.Add(answerTextBox);
            Controls.Add(answerLabel);
            Controls.Add(questionTextBox);
            Controls.Add(questionLabel);
            Controls.Add(closeButton);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(questionsDataGridView);
            Margin = new Padding(2, 2, 2, 2);
            Name = "QuestionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вопросы";
            Load += QuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView questionsDataGridView;
        private Button deleteButton;
        private Label questionLabel;
        private TextBox questionTextBox;
        private Label answerLabel;
        private TextBox answerTextBox;
        private Button addButton;
        private Button closeButton;
    }
}