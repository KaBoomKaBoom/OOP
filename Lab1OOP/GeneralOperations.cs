using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab1OOP
{
    public class GeneralOperations
    {
		public void createFaculty(List<Faculty> faculties)
		{
			Faculty faculty = new Faculty();
			faculties.Add(faculty);
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
            if (!status) Console.WriteLine("Check email!");
        }
        //Display University faculties
        public void displayFaculties(List<Faculty> faculties)
        {
            foreach (Faculty faculty in faculties)
            {
                faculty.showFaculty();
            }
        }
        //Display all faculties belonging to a field
        public void displayFacByField(List<Faculty> faculties)
        {
            Console.WriteLine("Which field?");
            var field = Console.ReadLine();
            if (!Enum.IsDefined(typeof(StudyField), field)) Console.WriteLine("Wrong study fiels!");
            else
            {
                foreach (Faculty faculty in faculties)
                {
                    if (Convert.ToString(faculty.studyField) == field) { faculty.showFaculty(); }
                }
            }
        }
        
    }
}
