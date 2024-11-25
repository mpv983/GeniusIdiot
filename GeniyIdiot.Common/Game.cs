
namespace GeniyIdiot.Common
{
    public class Game
    {
        public User User;
        public QuestionsStorage QuestionsStorage = new QuestionsStorage();
        public List<Question> Questions;
        public Question СurrentQuestion;
        private int сurrentQuestionIndex;
        public int CountQuestions;
        public int QuestionNumber;
        public UsersResultStorage UsersResultsStorage = new UsersResultStorage();
        public static readonly string Rules = "На размышления дается 10 секунд!\nНе успел - засчитывается неверный ответ!\n";

        public Game()
        {
            QuestionsStorage.AddFirstFiveQuestions();
            Questions = QuestionsStorage.GetRandomQuestions();
            CountQuestions = Questions.Count;
            User = new User("Неизвестно");
        }

        public Question GetNextQuestion()
        {
            сurrentQuestionIndex++;
            СurrentQuestion = Questions[сurrentQuestionIndex];
            return СurrentQuestion;
        }

        public string GetQuestionNumberText()
        {
            QuestionNumber++;
            return "Вопрос №" + QuestionNumber;
        }
        public void AcceptAnswer(int userAnswer)
        {
            if (userAnswer == СurrentQuestion.Answer)
            {
                User.AcceptRightAnswer();
            }
        }
        public bool End()
        {
            return сurrentQuestionIndex + 1 == CountQuestions;
        }
        public void Start()
        {
            User.CountRightAnswers = 0;
            сurrentQuestionIndex = -1;
            QuestionNumber = 0;
            Questions = QuestionsStorage.GetRandomQuestions();
            CountQuestions = Questions.Count;
            GetNextQuestion();
        }
    }
}
