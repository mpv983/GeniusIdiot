using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class ResultsForm : Form
    {
        UsersResultStorage usersResultStorage = new UsersResultStorage();
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = usersResultStorage.GetAll();
            dataGridView1.DataSource = results;
            dataGridView1.Columns["Name"].HeaderText = "Имя";
            dataGridView1.Columns["Diagnose"].HeaderText = "Диагноз";
            dataGridView1.Columns["CountRightAnswers"].HeaderText = "Ответов";
            dataGridView1.Columns["CountRightAnswers"].Width = 100;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
