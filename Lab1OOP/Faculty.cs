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
		public string name { get; set; }
		public string abbreviation { get; set; }
		public List<Student> students { get; set; }
		public StudyField studyField { get; set; }
		public Faculty insertFaculty()
		{
			Console.Write("Faculty name: "); name = Console.ReadLine();
			Console.Write("Faculty abbreviation: "); abbreviation = Console.ReadLine();
			students = new List<Student>();
			Console.Write("Study Field: "); var field = Console.ReadLine();
			if (field == "MECHANICAL_ENGINEERING") { studyField = StudyField.MECHANICAL_ENGINEERING; }
			else if (field == "SOFTWARE_ENGINEERING") { studyField = StudyField.SOFTWARE_ENGINEERING; }
			else if (field == "FOOD_TECHNOLOGY") { studyField = StudyField.FOOD_TECHNOLOGY; }
			else if (field == "URBANISM_ARCHITECTURE") { studyField = StudyField.URBANISM_ARCHITECTURE; }
			else if (field == "VETERINARY_MEDICINE") { studyField = StudyField.VETERINARY_MEDICINE; }
			else Console.WriteLine("Incorrect study field");
			return this;
		}

		// TodO name show -> print +
		public void printStudents()
        {
			foreach (Student student in students) {
				student.printStudent();
				Console.WriteLine();
			}

        }
        public void printStudentsEnrolled() { 

			foreach (Student student in students)
			{
				if (student.graduatioStatus == false) { student.printStudent(); }
			}
		}
        public void printStudentsGraduated()
        {
            foreach (Student student in students)
            {
                if (student.graduatioStatus == true) { student.printStudent(); }
            }
        }
        public void showFaculty() {
			Console.WriteLine("Faculty name: "+name);
			Console.WriteLine("Faculty abbreviation: " + abbreviation);
			Console.WriteLine("Faculty students: ");
			printStudents();
			Console.WriteLine("Faculty field: "+studyField);
			Console.WriteLine();
		}
	}
}
