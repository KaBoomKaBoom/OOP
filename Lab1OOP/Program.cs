
using Lab1OOP;

string option = "";
List<Faculty> faculties = new List<Faculty>();
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
			var faculty = new Faculty();
			faculties.Add(faculty); //add the faculty to the list of faculties
			break;
		//fo - Faculty operations
		case "fo":
			var opt = "";
			Console.WriteLine("1. cs - Create and assign a student to a faculty"); //+
			Console.WriteLine("2. gs - Graduate a student from a faculty");//+
			Console.WriteLine("3. des - Display current enrolled students (Graduates would be ignored)");//+
			Console.WriteLine("4. dgs - Display graduates (Currently enrolled students would be ignored)");//+
			Console.WriteLine("5. sf - Tell or not if a student belongs to this faculty");
			Console.WriteLine();
			Console.Write("Choose option: "); opt = Console.ReadLine();
			Console.WriteLine();
			switch (opt)
			{
				//Create and assign a student to a faculty
				case "cs":
					var succes = false;
					Console.WriteLine("Which faculty?");
					var facult=Console.ReadLine();
					foreach (Faculty faculty1 in faculties) {
						if (faculty1.name == facult) { faculty1.assignStudent(); succes = true; break; }
					}
					if (succes == true) Console.WriteLine("Student record succesfuly created");
					else Console.WriteLine("Student record was not created. Check faculty!");
					break;
				//Graduate a student from a faculty
				case "gs":
					//choose student's faculty 
					var status = false;
					Console.WriteLine("Which faculty?");
					var facult1 = Console.ReadLine();
					foreach (Faculty faculty1 in faculties)
					{
						if (faculty1.name == facult1) { faculty1.gradStatus(); status = true; }
					}
					if (status != true) Console.WriteLine("Check faculty name!");
					break;
				case "des":
                    var status = false;
                    Console.WriteLine("Which faculty?");
                    var facult2 = Console.ReadLine();
                    foreach (Faculty faculty1 in faculties)
                    {
                        if (faculty1.name == facult2) {
							faculty1.showStudentsEnrolled();
							status = true;
                        }
                    }
                    if (status != true) Console.WriteLine("Check faculty name!");
                    break;
				case "dgs":

                    var status = false;
                    Console.WriteLine("Which faculty?");
                    var facult3 = Console.ReadLine();
                    foreach (Faculty faculty1 in faculties)
                    {
                        if (faculty1.name == facult3)
                        {
							faculty1.showStudentsGraduated();
                            status = true;
                        }
                    }
                    if (status != true) Console.WriteLine("Check faculty name!");
                    break;
			}
			break;
	}

}
