using System;

namespace InspecTest.Data
{
    public class Answer
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public string SelectedOption { get; set; }
        public string UserId { get; set; } // or link to a User table
        public DateTime Timestamp { get; set; }
    }
}
