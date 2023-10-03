using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for (int i = 0; i < studentInformation.Length; i += 9)
            {
                var status = false;
                Console.WriteLine("Which faculty to assign next student?");
                string facultyName = Console.ReadLine();
                Student student = new Student();
                student.firstName = studentInformation[i];
                student.lastName = studentInformation[i + 1];
                student.email = studentInformation[i + 2];
                student.enrollmnetDate.year = Convert.ToInt16(studentInformation[i + 3]);
                student.enrollmnetDate.month = Convert.ToInt16(studentInformation[i + 4]);
                student.enrollmnetDate.day = Convert.ToInt16(studentInformation[i + 5]);
                student.birthDate.year = Convert.ToInt16(studentInformation[i + 6]);
                student.birthDate.month = Convert.ToInt16((studentInformation[i + 7]));
                student.birthDate.day = Convert.ToInt16(studentInformation[i + 8]);
                foreach (Faculty faculty in faculties)
                {
                    if (faculty.name == facultyName)
                    {
                        faculty.students.Add(student);
                        // TODO create log class 
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
