using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
	public class Student
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string email { get; set; }
		public Date enrollmnetDate { get; set; }
		public Date birthDate { get; set; }
		public bool graduatioStatus { get; set; } //if a student is graduated or no
		public Student insertStudent()
		{
			Console.Write(" Name: "); firstName = Console.ReadLine();
			Console.Write("Surname: "); lastName = Console.ReadLine();
			Console.Write("Email: "); email = Console.ReadLine();
			enrollmnetDate = new Date();
			Console.WriteLine("Enrollment date: "); enrollmnetDate = enrollmnetDate.insertDate();
			birthDate = new Date();
			Console.WriteLine("Birth date: "); birthDate = birthDate.insertDate();
			graduatioStatus = false;
			return this;
		}

		public void printStudent() {
			Console.WriteLine("Name: "+firstName);
			Console.WriteLine("Surname: "+lastName);
			Console.WriteLine("Email: "+email);
			Console.Write("Enrollmnet Date:"); enrollmnetDate.printDate(enrollmnetDate);
			Console.Write("Birth Date:"); birthDate.printDate(birthDate);

		}

		public void changeGradStatus() => graduatioStatus = true;
	}
}
