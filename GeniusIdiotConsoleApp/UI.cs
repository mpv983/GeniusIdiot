using GeniyIdiot.Common;
using static System.Net.Mime.MediaTypeNames;

namespace GeniusIdiotConsoleApp
{
    public class UI
    {
        public static bool IsYesOrNo(string text)
        {
            while (true)
            {
                Console.WriteLine($"{text} Введите \"Да\" или \"Нет\"");
                string answer = Console.ReadLine().ToLower();
                if (answer == "да")
                    return true;
                else if (answer == "нет")
                    return false;
            }
        }
        public static int GetNumber(string title)
        {
            int result;
            Console.WriteLine(title);

            while (true)
            {
                string answer = Console.ReadLine();
                if (!Validation.IsNumber(answer, out result, out var errorMessage))
                {
                    Console.WriteLine(errorMessage);
                }
                else return result;
            }
        }
        public static int GetNumber()
        {
            int result;
            while (true)
            {
                string answer = Console.ReadLine();
                if (!Validation.IsNumber(answer, out result, out var errorMessage))
                {
                    Console.WriteLine(errorMessage);
                }
                else return result;
            }
        }

        public static string GetUserText(string title)
        {
            string result;
            Console.WriteLine(title);
            while (true)
            {
                string answer = Console.ReadLine();
                if (!Validation.GetUserText(answer, out result, out var errorMessage))
                {
                    Console.WriteLine(errorMessage);
                }
                else return result;
            }
        }
        public static void ShowResultAsTable(Game game)
        {
            var userResults = game.UsersResultsStorage.UserResults;
            if (userResults.Count == 0)
            {
                Console.WriteLine($"Тест еще никто не решал");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Результаты тестов:");
                Console.WriteLine("|{0, -20}|{1, -20}|{2, -20}|",
                  "Имя", "Правильных ответов", "Диагноз");
                Console.WriteLine("----------------------------------------------------------------");
                foreach (var user in userResults)
                {
                    Console.WriteLine("|{0, -20}|{1, -20}|{2, -20}|",
                      user.Name, user.CountRightAnswers, user.Diagnose);
                }
                Console.WriteLine();
            }
        }
        public static void AddQuestion(Game game)
        {
            var text = GetUserText("Введите вопрос:");
            var answer = GetNumber("Введите ответ(целое число):");
            game.QuestionsStorage.Add(new Question(text, answer));
        }
        public static void DeleteQuestion(Game game)
        {
            var allQuestions = game.QuestionsStorage.GetAll();
            ShowQuestinonsAsTable(game);
            if (!game.QuestionsStorage.TryDelete(out var errorMessage))
            {
                Console.WriteLine(errorMessage);
            }
            else
            {
                var index = GetQuestionIndex();
                if (UI.IsYesOrNo("Уверены что хотите удалить вопрос?"))
                {
                    game.QuestionsStorage.Delete(index - 1);
                }
            }
        }
        public static void ShowQuestinonsAsTable(Game game)
        {
            var questions = game.QuestionsStorage.GetAll();
            Console.WriteLine("");
            Console.WriteLine("Список вопросов:");
            for (int i = 0; i < questions.Count; i++)
            {
                var index = i + 1;
                Console.WriteLine($"{index}. {questions[i].Text} ({questions[i].Answer})");
            }
            Console.WriteLine();
        }

        public static int GetQuestionIndex()
        {
            while (true)
            {
                var index = GetNumber("Введите номер вопроса для удаления:");
                var qs = new QuestionsStorage();
                if (index <= 0 || index > qs.GetAll().Count)
                {
                    Console.WriteLine("Введите число в пределах списка вопросов!");
                }
                else
                {
                    return index;
                }
            }
        }
        public static void AskQuestions(Game game)
        {
            for (int i = 0; i < game.CountQuestions; i++)
            {
                var number = game.GetQuestionNumberText();
                var text = game.Questions[i].Text;
                Console.WriteLine($"{number}: {text}");
                int userAnswer = GetNumber();
                int rightAnswer = game.Questions[i].Answer;//правильный ответ
                if (userAnswer == rightAnswer)
                {
                    game.User.AcceptRightAnswer();
                }
            }
        }
    }
}

