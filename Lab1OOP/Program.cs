
using Lab1OOP;

string option = "";
List<Faculty> faculties = new List<Faculty>();
var operations = new FacultyOperations();
var generalOperations= new GeneralOperations();
while (option != "q") {
	Console.WriteLine("1. cf - Create a new faculty"); //+
	Console.WriteLine("2. fo - Faculty operations"); //+
	Console.WriteLine("3. ssf - Search what faculty a student belongs to by email");
	Console.WriteLine("4. df - Display University faculties");
	Console.WriteLine("5. dff - Display all faculties belonging to a field");
	Console.WriteLine("6. q - Quit");
	Console.WriteLine();
	Console.Write("Choose option: "); option = Console.ReadLine();
	Console.WriteLine();

	switch (option)
	{
		//Create a new faculty
		case "cf":
			generalOperations.createFaculty(faculties);
			break;
		//fo - Faculty operations
		case "fo":
			var opt = "";
			Console.WriteLine("1. cs - Create and assign a student to a faculty"); //+
			Console.WriteLine("2. gs - Graduate a student from a faculty");//+
			Console.WriteLine("3. des - Display current enrolled students (Graduates would be ignored)");//+
			Console.WriteLine("4. dgs - Display graduates (Currently enrolled students would be ignored)");//+
			Console.WriteLine("5. sf - Tell or not if a student belongs to this faculty");//+
			Console.WriteLine();
			Console.Write("Choose option: "); opt = Console.ReadLine();
			Console.WriteLine();
			switch (opt)
			{
				//Create and assign a student to a faculty
				case "cs":
					operations.createAssignStudent(faculties);
					break;
				//Graduate a student from a faculty
				case "gs":
					operations.gradStatus(faculties);
					break;
                //Display current enrolled students (Graduates would be ignored)
                case "des":
					operations.showStudents(faculties, false);
                    break;
                //Display graduates (Currently enrolled students would be ignored)
                case "dgs":
					operations.showStudents(faculties, true);
                    break;
				case "sf":
					operations.checkSudent(faculties);
					break;
			}
			break;

	}

}
