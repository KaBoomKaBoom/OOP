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
		public Student()
		{
			Console.Write(" Name: "); firstName = Console.ReadLine();
			Console.Write("Surname: "); lastName = Console.ReadLine();
			Console.Write("Email: "); email = Console.ReadLine();
			Console.WriteLine("Enrollment date: "); enrollmnetDate = new Date();
			Console.WriteLine("Birth date: "); birthDate = new Date();
			graduatioStatus = false;
		}

		public void printStudent() {
			Console.WriteLine("Name: "+firstName);
			Console.WriteLine("Surname: "+lastName);
			Console.WriteLine("Email: "+email);
			Console.Write("Enrollmnet Date:"); enrollmnetDate.printDate(enrollmnetDate);
			Console.WriteLine();
			Console.Write("Birth Date:"); birthDate.printDate(birthDate);
		}

		public void changeGradStatus() => graduatioStatus = true;
	}
}
