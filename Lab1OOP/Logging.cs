namespace Lab1OOP
{
	public class Logging
    {
        public void logCreationOfFaculty(Faculty faculty) 
        {
            string logFileName = "Log.txt";
            File.AppendAllText(logFileName, $"[{DateTime.Now}]Created a new faculty: {faculty.name}");
            File.AppendAllText(logFileName, $"\n");
        }

        public void logAssigningToFaculty(Faculty faculty,Student student)
        {
            string logFileName = "Log.txt";
            File.AppendAllText(logFileName, $"[{DateTime.Now}]Created a new student: {student.firstName} {student.lastName}. Assigned to faculty: {faculty.name}");
            File.AppendAllText(logFileName, $"\n");
        }
        
        public void logGraduateStudent(Faculty faculty, Student student)
        {
            string logFileName = "Log.txt";
            File.AppendAllText(logFileName, $"[{DateTime.Now}]Graduated student: {student.firstName} {student.lastName}, from faculty: {faculty.name}");
            File.AppendAllText(logFileName, $"\n");
        }
    }
}
