using GeniyIdiot.Common;

namespace GeniusIdiotConsoleApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();

            while (true)
            {
                //приветствие
                game.User.Name = UI.GetUserText("Представьтесь, пожалуйста:");

                //тестирование
                game.Start();
                UI.AskQuestions(game);

                //Определяем диагноз
                game.User.Diagnose = Diagnose.GetDiagnose(game.CountQuestions, game.User.CountRightAnswers);
                game.UsersResultsStorage.Save(game.User);
                game.UsersResultsStorage.GetAll();

                //выводим результаты юзера
                Console.WriteLine("Количество правильных ответов: " + game.User.CountRightAnswers);
                Console.WriteLine($"Уважаемый {game.User.Name}, да Вы - {game.User.Diagnose}!");

                //предлагаем вывести общую таблицу
                if (UI.IsYesOrNo("Показать статистику?"))
                {
                    UI.ShowResultAsTable(game);
                }

                //Предлагаем добавить/удалить вопрос
                if (UI.IsYesOrNo("Хотите добавить вопрос?"))
                {
                    UI.AddQuestion(game);
                }
                if (UI.IsYesOrNo("Хотите удалить вопрос?"))
                {
                    UI.DeleteQuestion(game);
                }

                //предлагаем повторить
                if (UI.IsYesOrNo("Пройти заново?"))
                {
                    game.Start();
                }
                else { break; }
            }
        }
    }
}
