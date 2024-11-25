namespace GeniyIdiot.Common
{
    public class Diagnose
    {
        public static List<string> Diagnoses = new List<string>
        {
            "идиот",
            "кретин",
            "дурак",
            "нормальный",
            "талант",
            "гений"
        };

        public static string GetDiagnose(int countQuestions, int rightAnswers)
        {
            int countDiagnoses = Diagnoses.Count;
            double rightAnswersPercentage = (rightAnswers / (double)countQuestions) * 100.0;
            int index = 0;
            for (int i = 1; i <= countDiagnoses; i++)
            {
                if (rightAnswersPercentage <= i * 100.0 / countDiagnoses)
                {
                    index = i - 1; break;
                }
            }
            return Diagnoses[index];
        }
    }
}