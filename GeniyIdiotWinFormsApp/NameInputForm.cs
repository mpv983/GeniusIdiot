using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class NameInputForm : Form
    {
        public User user;
        public NameInputForm()
        {
            InitializeComponent();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            var check_nameInputTextBox = Validation.GetUserText(nameInputTextBox.Text, out var userName, out string errorMessageText);
            if (!check_nameInputTextBox)
            {
                MessageBox.Show(errorMessageText + " Введите имя.");
            }
            else
            {
                user = new User(userName);
                Close();
            }
        }
    }
}
