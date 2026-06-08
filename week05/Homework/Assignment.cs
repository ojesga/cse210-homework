using System;

namespace Homework
{
    public class Assignment
    {
        // Encapsulated private attributes shared by all assignments
        private string _studentName;
        private string _topic;

        // Base constructor used by derived classes to initialize shared state
        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        // Public getter method allowing derived classes to read the name safely
        public string GetStudentName()
        {
            return _studentName;
        }

        // Shared summary method
        public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }
    }
}