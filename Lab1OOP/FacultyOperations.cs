namespace Lab1OOP
{
	public class FacultyOperations
    {
        Logging logging = new Logging();    
        //Tell or not if a student belongs to this faculty
        public void checkSudent(List<Faculty> faculties)
        {
            var status = false;
            Console.WriteLine("Which faculty?(abbreviation)");
            var facult = Console.ReadLine();
            Console.WriteLine("Which student?(email)");
            var email=Console.ReadLine();
            var name = "";
            var surname = "";
            foreach (Faculty faculty in faculties)
            {
                if (faculty.abbreviation == facult)
                {
                    foreach (Student student in faculty.students)
                    {
                        if (email==student.email)
                        {
                            name=student.firstName; 
                            surname=student.lastName;
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
        public void gradStatus(List<Faculty> faculties) {
            var status = false;
            Console.WriteLine("Which faculty?(abbreviation)");
            var facult = Console.ReadLine();
			Console.WriteLine("Which student?(email)");
			var email = Console.ReadLine();

			// TODO no faculty1 type of names +
			foreach (Faculty faculty in faculties)
            {
                if (faculty.abbreviation == facult) {
                    foreach (Student student in faculty.students)
                    {
                        if (email==student.email)
                        {
                            student.changeGraduationStatus();
                            logging.logGraduateStudent(faculty, student);
							status = true;
                            break;
                        }
                    }
                }
            }
            if (status != true) Console.WriteLine("Check faculty or student name!\n");
        }
		//Create a student
        // TODO addStudent rename
		public void assignStudent(List<Faculty> faculties)
		{
			var status = false;
			Console.WriteLine("Which faculty?(abbreviation)");
			var facultyName = Console.ReadLine();
			foreach (Faculty faculty in faculties)
			{
				if (faculty.abbreviation == facultyName)
				{
					Student student = new Student();
                    student = student.createStudent();
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

		public void printStudents(List<Faculty> faculties, bool graduated)
        {
            var status = false;
            Console.WriteLine("Which faculty?(abbreviation)");
            var facult = Console.ReadLine();
            foreach (Faculty faculty1 in faculties)
            {
                if (faculty1.abbreviation == facult)
                {
                    switch (graduated) {
                        case true:
                            faculty1.printStudentsGraduated();
                            break;
                        case false:
                            faculty1.printStudentsEnrolled();
                            break;
                    }
                    status = true;break;
                }
            }
            if (status != true) Console.WriteLine("Check faculty name!\n");
        }
    }
}
