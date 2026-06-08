using System;

namespace Homework
{
    public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        // Constructor passing studentName and topic upwards to the base constructor
        public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
            : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        // Specialized method unique to math homework tracking
        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} Problems {_problems}";
        }
    }
}