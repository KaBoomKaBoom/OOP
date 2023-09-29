using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    public class FacultyOperations
    {
        //Tell or not if a student belongs to this faculty
        public void checkSudent(List<Faculty> faculties)
        {
            var status = false;
            Console.WriteLine("Which faculty?");
            var facult = Console.ReadLine();
            Console.WriteLine("Which student?");
            Console.Write("Name: "); var name = Console.ReadLine();
            Console.Write("Surname: "); var surname = Console.ReadLine();
            foreach (Faculty faculty in faculties)
            {
                if (faculty.name == facult)
                {
                    foreach (Student student in faculty.students)
                    {
                        if (name == student.firstName && surname == student.lastName)
                        {
                            status = true;
                            break;
                        }
                    }
                    if (status)
                    {
                        Console.WriteLine("Student " + name + " " + surname + " belongs to faculty " + facult); return;
                    }
                }
            }
            Console.WriteLine("Does not belong to faculty\n");
        }
        //Graduate a student from a faculty
        public void gradStatus(List<Faculty> faculties,string logPath) {
            var status = false;
            Console.WriteLine("Which faculty?");
            var facult = Console.ReadLine();
            Console.WriteLine("Which student?");
            Console.Write("Name: "); var name = Console.ReadLine();
            Console.Write("Surname: "); var surname = Console.ReadLine();
            foreach (Faculty faculty1 in faculties)
            {
                if (faculty1.name == facult) {
                    foreach (Student student in faculty1.students)
                    {
                        if (name == student.firstName && surname == student.lastName)
                        {
                            student.changeGradStatus();
							File.AppendAllText(logPath, $"Graduated student: {student.firstName} {student.lastName}, from faculty: {faculty1.name}");
							status = true;
                            break;
                        }
                    }
                }
            }
            if (status != true) Console.WriteLine("Check faculty or student name!\n");
        }
		//Create a student
		public void createAssignStudent(List<Faculty> faculties,string logPath)
		{
			var status = false;
			Console.WriteLine("Which faculty?");
			var facult = Console.ReadLine();
			foreach (Faculty faculty1 in faculties)
			{
				if (faculty1.name == facult)
				{
					Student student = new Student();
                    student = student.insertStudent();
					faculty1.students.Add(student);
					File.AppendAllText(logPath, $"Created a new student: {student.firstName} {student.lastName}. Assigned to faculty: {faculty1.name}");
					status = true;
					break;
				}
			}
			if (status == true) Console.WriteLine("Student record succesfuly created\n");
			else Console.WriteLine("Student record was not created. Check faculty\n!");
			
		}

		public void showStudents(List<Faculty> faculties, bool graduated)
        {
            var status = false;
            Console.WriteLine("Which faculty?");
            var facult = Console.ReadLine();
            foreach (Faculty faculty1 in faculties)
            {
                if (faculty1.name == facult)
                {
                    switch (graduated) {
                        case true:
                            faculty1.showStudentsGraduated();
                            break;
                        case false:
                            faculty1.showStudentsEnrolled();
                            break;
                    }
                    status = true;break;
                }
            }
            if (status != true) Console.WriteLine("Check faculty name!\n");
        }
    }
}
