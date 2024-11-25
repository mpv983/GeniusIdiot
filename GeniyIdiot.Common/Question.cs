﻿namespace GeniyIdiot.Common
{
    public class Question
    {
        public string Text { get; set; }
        public int Answer { get; set; }
        public Question(string text, int answer)
        {
            Text = text;
            Answer = answer;
        }
    }
}

