﻿	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab1OOP
{
	 public class Date
	{
		public int year { get; set; }
		public int month { get; set; }
		public int day { get; set; }

		public Date insertDate()
		{
			Console.Write("Day: "); day = Convert.ToInt16(Console.ReadLine());
			Console.Write("Month: "); month = Convert.ToInt16(Console.ReadLine());
			Console.Write("Year: "); year = Convert.ToInt16(Console.ReadLine());
			return this;
		}

		public void printDate(Date date) {
			Console.WriteLine(date.day + "/" + date.month + "/" + date.year);
			
		}
	}
}
