namespace Lab1OOP
{
	public class batchOperations
    {
        Logging logging = new Logging();
        public void batchGraduate(List<Faculty> faculties)
        {
            string fileName = "ForGraduation";
            string[] emails = File.ReadAllLines(fileName+".txt");
            foreach (var email in emails)
            {
                foreach (var faculty in faculties)
                {
                    foreach (var student in faculty.students)
                    {
                        if (email == student.email)
                        {
                            student.changeGraduationStatus();
                            logging.logGraduateStudent(faculty, student);
                        }
                    }
                    
                }
            }
        }
        public void batchEnrollment(List<Faculty> faculties) 
        {
            string fileName = "ForEnrollment";
            string[] studentInformation = File.ReadAllLines(fileName + ".txt");
            for (int i = 0; i < studentInformation.Length; i += 10)
            {
                var status = false;
				string facultyName = studentInformation[i];
                Student student = new Student();
                student.firstName = studentInformation[i+1];
                student.lastName = studentInformation[i + 2];
                student.email = studentInformation[i + 3];

                Date enroll = new Date();
                enroll.year = int.Parse(studentInformation[i + 4]);
                enroll.month = int.Parse(studentInformation[i + 5]);
                enroll.day = int.Parse(studentInformation[i + 6]);
                student.enrollmnetDate = enroll;

                Date birth = new Date();
                birth.year = int.Parse(studentInformation[i + 7]);
                birth.month = int.Parse((studentInformation[i + 8]));
                birth.day = int.Parse(studentInformation[i + 9]);
                student.birthDate = birth;
                foreach (Faculty faculty in faculties)
                {
                    if (faculty.abbreviation == facultyName)
                    {
                        faculty.students.Add(student);
                        logging.logAssigningToFaculty(faculty, student);
                        status = true;
                        break;
                    }
                }
                if (status == true) Console.WriteLine("Student record succesfuly created\n");
                else Console.WriteLine("Student record was not created. Check faculty\n!");
            }

        }
    }
}
