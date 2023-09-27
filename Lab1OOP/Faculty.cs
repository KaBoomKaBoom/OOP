using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
	
	public enum StudyField { 
		MECHANICAL_ENGINEERING,
		SOFTWARE_ENGINEERING,
		FOOD_TECHNOLOGY,
		URBANISM_ARCHITECTURE,
		VETERINARY_MEDICINE
	}
	public class Faculty
	{
		public string name;
		public string abbreviation;
		public List<Student> students;
		public StudyField studyField;
		public Faculty() {
			Console.Write("Faculty name: "); name = Console.ReadLine();
			Console.Write("Faculty abbreviation: ");  abbreviation = Console.ReadLine();
			students = new List<Student>();
			Console.Write("Study Field: "); var field= Console.ReadLine();
			if (field == "MECHANICAL_ENGINEERING") { studyField = StudyField.MECHANICAL_ENGINEERING; }
			else if (field == "SOFTWARE_ENGINEERING") { studyField = StudyField.SOFTWARE_ENGINEERING; }
			else if (field == "FOOD_TECHNOLOGY") { studyField = StudyField.FOOD_TECHNOLOGY; }
			else if (field == "URBANISM_ARCHITECTURE") { studyField = StudyField.URBANISM_ARCHITECTURE; }
			else if (field == "VETERINARY_MEDICINE") { studyField = StudyField.VETERINARY_MEDICINE; }
			else Console.WriteLine("Incorrect study field");
		}

		public void assignStudent() {
			Student student=new Student();
			students.Add(student);
		}
        public void showStudent()
        {
			foreach (Student student in students) {
				student.printStudent();
			}
        }
        public void showStudentsEnroolled() { 

			foreach (Student student in students)
			{
				if (student.graduatioStatus == false) { student.printStudent; }
			}
		}
        public void showStudentsGraduated()
        {
            foreach (Student student in students)
            {
                if (student.graduatioStatus == true) { student.printStudent; }
            }
        }
        public void showFaculty() {
			Console.WriteLine("Faculty name: "+name);
			Console.WriteLine("Faculty abbreviation: " + abbreviation);
			Console.WriteLine("Faculty students: ");
			showStudents();
			Console.WriteLine("Faculty field: "+studyField); 
		}

		public void linkStudent(List<Faculty> faculties) {
			var status = false;
			Console.WriteLine("Which faculty?");
			var facult = Console.ReadLine();
			foreach (Faculty faculty1 in faculties)
			{
				if (faculty1.name == facult) { faculty1.assignStudent(); status = true; break; }
			}
			if (status == true) Console.WriteLine("Student record succesfuly created");
			else Console.WriteLine("Student record was not created. Check faculty!");
		}

		public void gradStatus() {
			Console.Write("Name: "); var name=Console.ReadLine();
			Console.Write("Surname: "); var surname=Console.ReadLine();
			var status = false;
			foreach (Student student in students) {
				if (name == student.firstName && surname == student.lastName)
				{
					student.changeGradStatus();
					status = true;
					break;
				}
			}
			if (status) Console.WriteLine("Status changed");
			else Console.WriteLine("No such student");
		}
	}
	
}
