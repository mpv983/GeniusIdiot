namespace GeniyIdiotWinFormsApp
{
    partial class ResultsForm
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
            components = new System.ComponentModel.Container();
            usersResultStorageBindingSource = new BindingSource(components);
            usersResultStorageBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)usersResultStorageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usersResultStorageBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // usersResultStorageBindingSource
            // 
            usersResultStorageBindingSource.DataSource = typeof(GeniyIdiot.Common.UsersResultStorage);
            // 
            // usersResultStorageBindingSource1
            // 
            usersResultStorageBindingSource1.DataSource = typeof(GeniyIdiot.Common.UsersResultStorage);
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(688, 379);
            dataGridView1.TabIndex = 0;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeButton.Location = new Point(579, 407);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(123, 41);
            closeButton.TabIndex = 2;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 460);
            Controls.Add(closeButton);
            Controls.Add(dataGridView1);
            Name = "ResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результаты";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)usersResultStorageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)usersResultStorageBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource usersResultStorageBindingSource;
        private BindingSource usersResultStorageBindingSource1;
        private DataGridView dataGridView1;
        private Button closeButton;
    }
}