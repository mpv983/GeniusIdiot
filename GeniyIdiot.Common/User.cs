namespace GeniyIdiot.Common
{
    public class User
    {
        public string Name { get; set; }
        public string Diagnose { get; set; }
        public int CountRightAnswers { get; set; } = 0;

        public User(string name)
        {
            Name = name;
        }
        public void AcceptRightAnswer()
        {
            CountRightAnswers++;
        }
    }
}

