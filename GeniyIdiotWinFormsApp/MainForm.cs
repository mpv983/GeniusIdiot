using GeniyIdiot.Common;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        public Game Game;
        double timeLeft = 10;
        int timeInMiliseconds;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // èãðà
            var nameInputForm = new NameInputForm();
            nameInputForm.ShowDialog();
            Game = new Game();
            Game.User = nameInputForm.user;
            userNametextBox.Text = Game.User.Name;

            // âèäèìîñòü èíòåðôåéñà
            VisibleSettingsEndGame();
            AcceptButton = startButton;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            var parsed = Validation.IsNumber(userAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                AcceptUserAnswer(userAnswer);
            }
        }

        private void AcceptUserAnswer(int userAnswer)
        {
            Game.AcceptAnswer(userAnswer);
            if (Game.End())
            {
                VisibleSettingsEndGame();
                timer.Stop();
                Game.User.Diagnose = Diagnose.GetDiagnose(Game.CountQuestions, Game.User.CountRightAnswers);
                Game.UsersResultsStorage.Save(Game.User);
                Game.UsersResultsStorage.GetAll();
                MessageBox.Show($"Óâàæàåìûé {Game.User.Name}, äà Âû - {Game.User.Diagnose}!");
                return;
            }
            Game.GetNextQuestion();
            questionTextLabel.Text = Game.ÑurrentQuestion.Text;
            questionNumberLabel.Text = Game.GetQuestionNumberText();
            userAnswerTextBox.Clear();
            TimerStart();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm();
            Hide();
            resultsForm.ShowDialog();
            Show();

        }

        private void questionsButton_Click(object sender, EventArgs e)
        {
            var questionForm = new QuestionsForm(this);
            Hide();
            questionForm.ShowDialog();
            Show();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Game.Start();
            questionNumberLabel.Text = Game.GetQuestionNumberText();
            questionTextLabel.Text = Game.ÑurrentQuestion.Text;
            VisibleSettingsStartGame();
            AcceptButton = nextButton;
            MessageBox.Show(Game.Rules);
            TimerStart();
        }
        private void VisibleSettingsEndGame()
        {
            userAnswerTextBox.Clear();
            startButton.Visible = true;
            userAnswerTextBox.Enabled = false;
            nextButton.Enabled = false;
            userAnswerTextBox.Visible = false;
            nextButton.Visible = false;
            questionNumberLabel.Visible = false;
            questionTextLabel.Visible = false;
            progressBar.Visible = false;
            timerLabel.Visible = false;
        }

        private void VisibleSettingsStartGame()
        {
            questionNumberLabel.Visible = true;
            questionTextLabel.Visible = true;
            startButton.Visible = false;
            userAnswerTextBox.Visible = true;
            nextButton.Visible = true;
            userAnswerTextBox.Enabled = true;
            nextButton.Enabled = true;
            progressBar.Visible = true;
            timerLabel.Visible = true;
            userAnswerTextBox.Clear();
        }

        private void userNametextBox_TextChanged(object sender, EventArgs e)
        {
            Game.User.Name = userNametextBox.Text;
        }

        private void nameChangeButton(object sender, EventArgs e)
        {
            var nameInputForm = new NameInputForm();
            nameInputForm.ShowDialog();
            Game.User = nameInputForm.user;
            userNametextBox.Text = Game.User.Name;
        }

        private void TimerStart()
        {
            timeLeft = 10;
            timeInMiliseconds = (int)timeLeft*10;
            timer.Start();
            progressBar.Value = timeInMiliseconds;
            timerLabel.Text = timeLeft.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timeInMiliseconds--;

            timerLabel.Text = timeInMiliseconds.ToString();
            progressBar.Value = timeInMiliseconds;
            if (timeInMiliseconds == 0)
            {
                timer.Stop();
                AcceptUserAnswer(0);
            }
        }
    }
}
