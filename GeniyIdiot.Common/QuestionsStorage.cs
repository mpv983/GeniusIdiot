namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        public string Path = @"Questions.json";
        public FileHelper FileHelper;


        public QuestionsStorage()
        {
            this.Path = Path;
            this.FileHelper = new FileHelper(Path);
        }

        public List<Question> GetRandomQuestions()
        {
            var allQuestions = GetAll();
            var questions = new List<Question>();
            var random = new Random();
            var countQuestions = 0;
            if (allQuestions.Count < 5)
            {
                countQuestions = allQuestions.Count;
            }
            else countQuestions = 5;

            for (int i = 0; i < countQuestions; i++)
            {
                var index = random.Next(0, allQuestions.Count);

                questions.Add(allQuestions[index]);
                allQuestions.RemoveAt(index);
            }
            return questions;
        }
        public List<Question> GetAll()
        {
            var questions = FileHelper.Read<Question>();
            return questions;
        }

        public void AddFirstFiveQuestions()
        {
            var baseQuestions = new List<Question>(){
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
            new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 5)
            };
            if (!System.IO.File.Exists(Path))
            {
                FileHelper.Write(baseQuestions);
            }
        }
        public void Add(Question question)
        {
            var allQuestions = GetAll();
            allQuestions.Add(question);
            FileHelper.Write(allQuestions);
        }
        public bool TryDelete(out string errorMessage)
        {
            var allQuestions = GetAll();
            if (allQuestions.Count == 1)
            {
                errorMessage = $"В игре должен быть хотя бы 1 вопрос.";
                return false;
            }
            else
            {
                errorMessage = string.Empty;
                return true;
            }
        }
        public void Delete(int index)
        {
            var allQuestions = GetAll();
            allQuestions.RemoveAt(index);
            FileHelper.Write(allQuestions);
        }
    }
}
