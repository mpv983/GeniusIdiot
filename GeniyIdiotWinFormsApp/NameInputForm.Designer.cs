namespace GeniyIdiotWinFormsApp
{
    partial class NameInputForm
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
            nameInputlabel = new Label();
            nameInputTextBox = new TextBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // nameInputlabel
            // 
            nameInputlabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameInputlabel.AutoSize = true;
            nameInputlabel.Font = new Font("Segoe UI", 12F);
            nameInputlabel.Location = new Point(170, 22);
            nameInputlabel.Margin = new Padding(2, 0, 2, 0);
            nameInputlabel.Name = "nameInputlabel";
            nameInputlabel.Size = new Size(103, 21);
            nameInputlabel.TabIndex = 0;
            nameInputlabel.Text = "Введите имя:";
            // 
            // nameInputTextBox
            // 
            nameInputTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameInputTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            nameInputTextBox.ForeColor = SystemColors.MenuHighlight;
            nameInputTextBox.Location = new Point(16, 53);
            nameInputTextBox.Margin = new Padding(2, 2, 2, 2);
            nameInputTextBox.Name = "nameInputTextBox";
            nameInputTextBox.Size = new Size(418, 50);
            nameInputTextBox.TabIndex = 1;
            nameInputTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // okButton
            // 
            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.Location = new Point(328, 120);
            okButton.Margin = new Padding(2, 2, 2, 2);
            okButton.Name = "okButton";
            okButton.Size = new Size(105, 24);
            okButton.TabIndex = 2;
            okButton.Text = "Готово";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // NameInputForm
            // 
            AcceptButton = okButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 161);
            Controls.Add(okButton);
            Controls.Add(nameInputTextBox);
            Controls.Add(nameInputlabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "NameInputForm";
            Padding = new Padding(14, 12, 14, 12);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Здрасти";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameInputlabel;
        private TextBox nameInputTextBox;
        private Button okButton;
    }
}