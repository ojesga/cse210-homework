using System;

namespace Homework
{
    public class WritingAssignment : Assignment
    {
        private string _title;

        // Constructor passing studentName and topic upwards to the base constructor
        public WritingAssignment(string studentName, string topic, string title) 
            : base(studentName, topic)
        {
            _title = title;
        }

        // Specialized method unique to writing homework tracking
        public string GetWritingInformation()
        {
            // Calls the base class getter method to access the private student name string
            string studentName = GetStudentName();
            return $"{_title} by {studentName}";
        }
    }
}