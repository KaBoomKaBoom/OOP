﻿using System;
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

		public void showStudents()
        {
			foreach (Student student in students) {
				student.printStudent();
			}
        }
        public void showStudentsEnrolled() { 

			foreach (Student student in students)
			{
				if (student.graduatioStatus == false) { student.printStudent(); }
			}
		}
        public void showStudentsGraduated()
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
			showStudents();
			Console.WriteLine("Faculty field: "+studyField); 
		}
	}
}