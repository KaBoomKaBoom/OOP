using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    public class Logging
    {
        public void logCreationOfFaculty(Faculty faculty) 
        {
            string logFileName = "Log.txt";
            File.AppendAllText(logFileName, $"Created a new faculty: {faculty.name}");
        }

        public void logAssigningToFaculty(Faculty faculty,Student student)
        {
            string logFileName = "Log.txt";
            File.AppendAllText(logFileName, $"Created a new student: {student.firstName} {student.lastName}. Assigned to faculty: {faculty.name}");
        }
        
        public void logGraduateStudent(Faculty faculty, Student student)
        {
            string logFileName = "Log.txt";
            File.AppendAllText(logFileName, $"Graduated student: {student.firstName} {student.lastName}, from faculty: {faculty.name}");
        }
    }
}
