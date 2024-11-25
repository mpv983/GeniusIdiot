
namespace GeniyIdiot.Common
{
    public class Validation
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

        public static bool IsNumber(string value,out int result, out string errorMessage)
        {
            try
            {
                result = Convert.ToInt32(value);
                errorMessage = "";
                return true;
            }
            catch (FormatException)
            {
                result = 0;
                errorMessage = "Введите целое число!";
                return false;
            }
            catch (OverflowException)
            {
                result = 0;
                errorMessage = "Число слишком велико или мало";
                return false;
            }
        }

        public static bool GetUserText(string value, out string text, out string errorMessage)
        {
            if (String.IsNullOrEmpty(value))
            {
                errorMessage = $"Строка пуста.";
                text = string.Empty;
                return false;
            }
            else
            {
                errorMessage = string.Empty;
                text = value;
                return true;
            }
        }

    }
}

