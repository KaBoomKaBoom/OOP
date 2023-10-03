namespace Lab1OOP
{
	public class GeneralOperations
    {
        Logging logging = new Logging();
        public void createFaculty(List<Faculty> faculties)
		{
            var status = false;
			Faculty faculty = new Faculty();
            faculty = faculty.insertFaculty();
            foreach (var facult in faculties) { 
                if(faculty.name==facult.name) status = true;
            }
            if (!status) { faculties.Add(faculty); logging.logCreationOfFaculty(faculty); }
            else Console.WriteLine("Such faculty already exist!\n");
			
		}
		//Search by email
		public void searchByEmail(List<Faculty> faculties)
        {
            var status = false;
            Console.WriteLine("Enter a valid email: ");
            var email = Console.ReadLine();
            foreach (Faculty faculty in faculties)
            {
                foreach (Student student in faculty.students)
                {
                    if (student.email == email)
                    {
                        Console.WriteLine("Student: " + student.firstName + student.lastName);
                        Console.WriteLine("Faculty: " + faculty);
                        status = true;
                    }
                    if (status) break;
                }
                if (status) break;
            }
            if (!status) Console.WriteLine("Such email does not exist!\n");
        }
        //Display University faculties
        public void displayFaculties(List<Faculty> faculties)
        {
            if (faculties.Count != 0)
            {
                foreach (Faculty faculty in faculties)
                {
                    faculty.showFaculty();
                }
            }
            else Console.WriteLine("No faculties registered\n");
        }
        //Display all faculties belonging to a field
        public void displayFaultiesByStudyField(List<Faculty> faculties)
        {
            if (faculties.Count != 0)
            {
                Console.WriteLine("Which field?");
                var field = Console.ReadLine();
                if (!Enum.IsDefined(typeof(StudyField), field)) Console.WriteLine("Wrong study field!\n");
                else
                {
                    foreach (Faculty faculty in faculties)
                    {
                        if (Convert.ToString(faculty.studyField) == field) { faculty.showFaculty(); }
                    }
                }
            }
			else Console.WriteLine("No faculties registered\n");
		}
        
    }
}
