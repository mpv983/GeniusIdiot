using GeniyIdiot.Common;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class QuestionsForm : Form
    {
        QuestionsStorage questionsStorage = new QuestionsStorage();
        List<Question> allQuestions;
        FileHelper fileHelper;
        MainForm mainForm;
        public QuestionsForm(MainForm owner)
        {
            InitializeComponent();
            mainForm = owner;
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            allQuestions = questionsStorage.GetAll();
            questionsDataGridView.DataSource = allQuestions;
            questionsDataGridView.Columns["Answer"].Width = 50;
            questionsDataGridView.Columns["Answer"].HeaderText = "Ответ";
            questionsDataGridView.Columns["Text"].HeaderText = "Вопрос";
            fileHelper = questionsStorage.FileHelper;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!questionsStorage.TryDelete(out var errorMessage))
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                int index = questionsDataGridView.CurrentRow.Index;
                questionsStorage.Delete(index);
                UpdateDataGridView();
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateDataGridView()
        {
            allQuestions = questionsStorage.GetAll();
            questionsDataGridView.DataSource = allQuestions;
        }

        private void Add()
        {
            //Валидация полей
            var check_questionTextBox = Validation.GetUserText(questionTextBox.Text, out var userQuestion, out string errorMessageText);
            if (!check_questionTextBox)
            {
                MessageBox.Show(errorMessageText + " Введите текст вопроса.");
            }
            var check_AnswerTextBox = Validation.IsNumber(answerTextBox.Text, out int userAnswer, out string errorMessageAnswer);
            if (!check_AnswerTextBox)
            {
                MessageBox.Show("Ответом должно являться целое число. " + errorMessageAnswer);
            }
            //Добавление вопроса
            if (check_questionTextBox && check_AnswerTextBox)
            {
                questionsStorage.Add(new Question(userQuestion, userAnswer));
                UpdateDataGridView();
                questionTextBox.Clear();
                answerTextBox.Clear();
            }
        }

        private void questionsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                if (!questionsStorage.TryDelete(out var errorMessage))
                {
                    MessageBox.Show(errorMessage);
                }
                else
                {
                    int index = questionsDataGridView.CurrentRow.Index;
                    questionsStorage.Delete(index);
                    UpdateDataGridView();
                }
            }
        }
    }
}
