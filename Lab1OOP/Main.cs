﻿using Lab1OOP;

// FInal version
var fileManager = new FileManager();
List<Faculty> faculties = fileManager.StartSession();
var generalOperations= new GeneralOperations();
var options=new Options();
var batchOperations=new batchOperations();
string option = "";

while (option != "q") {
	// TODO Write a function +
	option = options.generalOptions(option);
	switch (option)
	{
		//Create a new faculty
		case "cf":
			generalOperations.createFaculty(faculties);
			break;
		//fo - Faculty operations
		case "fo":
            // TOdo move to function +
            // TODO move the switch to a different function +
            options.facultyOptions(faculties);
			break;
		//Search what faculty a student belongs to by email
		case "ssf":
			generalOperations.searchByEmail(faculties);
			break;
		//Display University faculties
		case "df":
			generalOperations.displayFaculties(faculties);
			break;
		//Display all faculties belonging to a field
		case "dff":
			generalOperations.displayFaultiesByStudyField(faculties);	
			break;
		//save current session
		//exit the system
		case "eff":
			batchOperations.batchEnrollment(faculties);
			break;
		case "gff":
			batchOperations.batchGraduate(faculties);	
			break;
		case "q":
			break;
		default:
			Console.WriteLine("Invalid option!\n");
			break;
	}
}
fileManager.SaveFacultiesToJson(faculties);
