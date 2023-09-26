	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab1OOP
{
	 public class Date
	{
		public int year;
		public int month;
		public int day;

		public Date() {
			Console.Write("Day: "); day = Convert.ToInt16(Console.ReadLine());
			Console.Write("Month: "); month = Convert.ToInt16(Console.ReadLine());
			Console.Write("Year: "); year = Convert.ToInt16(Console.ReadLine());
		}
		
		public void printDate(Date date) {
			Console.Write(date.day + "/" + date.month + "/" + date.year);
			
		}
	}
}
