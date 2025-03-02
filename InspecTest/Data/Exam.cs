using System;
using System.Collections.Generic;

namespace InspecTest.Data
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // Possibly a duration in minutes or both
        // public int DurationMinutes { get; set; }

        // Relationship: One Exam has many Questions
        public ICollection<Question> Questions { get; set; }
    }
}
