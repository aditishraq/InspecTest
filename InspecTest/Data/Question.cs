namespace InspecTest.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string CorrectOption { get; set; }

        // Foreign key to Exam
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
    }
}
