namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            userNametextBox = new TextBox();
            resultsButton = new Button();
            questionsButton = new Button();
            startButton = new Button();
            userNameLabel = new Label();
            getNameButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            timerLabel = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.AutoSize = true;
            nextButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextButton.Dock = DockStyle.Bottom;
            nextButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nextButton.Location = new Point(14, 292);
            nextButton.Margin = new Padding(2);
            nextButton.MinimumSize = new Size(0, 40);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(532, 40);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Segoe UI", 11F);
            questionNumberLabel.ForeColor = SystemColors.ControlDarkDark;
            questionNumberLabel.Location = new Point(16, 162);
            questionNumberLabel.Margin = new Padding(2, 0, 2, 0);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(90, 20);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №0";
            // 
            // questionTextLabel
            // 
            questionTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            questionTextLabel.AutoEllipsis = true;
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI", 11F);
            questionTextLabel.Location = new Point(14, 187);
            questionTextLabel.Margin = new Padding(2, 0, 2, 0);
            questionTextLabel.MaximumSize = new Size(500, 0);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(108, 20);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userAnswerTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userAnswerTextBox.ForeColor = SystemColors.MenuHighlight;
            userAnswerTextBox.Location = new Point(14, 249);
            userAnswerTextBox.Margin = new Padding(5);
            userAnswerTextBox.MinimumSize = new Size(4, 40);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.PlaceholderText = "Введите ответ";
            userAnswerTextBox.Size = new Size(531, 40);
            userAnswerTextBox.TabIndex = 3;
            userAnswerTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // userNametextBox
            // 
            userNametextBox.BackColor = SystemColors.Control;
            userNametextBox.BorderStyle = BorderStyle.None;
            userNametextBox.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userNametextBox.ForeColor = SystemColors.Highlight;
            userNametextBox.Location = new Point(16, 27);
            userNametextBox.Margin = new Padding(2);
            userNametextBox.Name = "userNametextBox";
            userNametextBox.PlaceholderText = "Введите имя";
            userNametextBox.Size = new Size(283, 25);
            userNametextBox.TabIndex = 5;
            userNametextBox.WordWrap = false;
            userNametextBox.TextChanged += userNametextBox_TextChanged;
            // 
            // resultsButton
            // 
            resultsButton.Location = new Point(403, 55);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(140, 40);
            resultsButton.TabIndex = 9;
            resultsButton.Text = "Статистика";
            resultsButton.UseVisualStyleBackColor = true;
            resultsButton.Click += resultsButton_Click;
            // 
            // questionsButton
            // 
            questionsButton.Location = new Point(403, 10);
            questionsButton.Margin = new Padding(2);
            questionsButton.Name = "questionsButton";
            questionsButton.Size = new Size(140, 40);
            questionsButton.TabIndex = 10;
            questionsButton.Text = "Вопросы";
            questionsButton.UseVisualStyleBackColor = true;
            questionsButton.Click += questionsButton_Click;
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            startButton.BackColor = SystemColors.Control;
            startButton.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Segoe UI Semibold", 16.25F, FontStyle.Bold);
            startButton.ForeColor = SystemColors.HotTrack;
            startButton.Location = new Point(14, 196);
            startButton.Name = "startButton";
            startButton.Size = new Size(531, 83);
            startButton.TabIndex = 11;
            startButton.Text = "Начать игру";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(14, 10);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(75, 15);
            userNameLabel.TabIndex = 12;
            userNameLabel.Text = "Имя игрока:";
            // 
            // getNameButton
            // 
            getNameButton.FlatAppearance.BorderSize = 0;
            getNameButton.FlatStyle = FlatStyle.Flat;
            getNameButton.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            getNameButton.ForeColor = SystemColors.WindowFrame;
            getNameButton.Location = new Point(9, 54);
            getNameButton.Margin = new Padding(0);
            getNameButton.Name = "getNameButton";
            getNameButton.Size = new Size(73, 24);
            getNameButton.TabIndex = 13;
            getNameButton.Text = "Изменить";
            getNameButton.UseVisualStyleBackColor = true;
            getNameButton.Click += nameChangeButton;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Segoe UI", 6F);
            timerLabel.Location = new Point(548, 332);
            timerLabel.Margin = new Padding(2, 0, 2, 0);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(9, 11);
            timerLabel.TabIndex = 15;
            timerLabel.Text = "0";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(16, 335);
            progressBar.Margin = new Padding(2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(528, 6);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 16;
            // 
            // MainForm
            // 
            AcceptButton = nextButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 344);
            Controls.Add(progressBar);
            Controls.Add(timerLabel);
            Controls.Add(getNameButton);
            Controls.Add(userNameLabel);
            Controls.Add(startButton);
            Controls.Add(questionsButton);
            Controls.Add(resultsButton);
            Controls.Add(userNametextBox);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Margin = new Padding(2);
            MinimumSize = new Size(572, 318);
            Name = "MainForm";
            Padding = new Padding(14, 12, 14, 12);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений - Идиот";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private Button resultsButton;
        private Button questionsButton;
        private Label userNameLabel;
        private Button getNameButton;
        public TextBox userNametextBox;
        public Button startButton;
        private System.Windows.Forms.Timer timer;
        private Label timerLabel;
        private ProgressBar progressBar;
    }
}
