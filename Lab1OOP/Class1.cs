using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lab1OOP
{
	public class FileManager
	{
		public void SaveFacultiesToJson(List<Faculty> facultyList)
		{


			string jsonFileName = @"C:\Users\Victor\source\repos\OOP\Lab1OOP\Faculties.json";
			var options = new JsonSerializerOptions
			{
				WriteIndented = true
			};
			// Serialize the list of faculties to JSON
			string jsonString = JsonSerializer.Serialize(facultyList, options);
			// Write the JSON data to a file
			File.WriteAllText(jsonFileName, jsonString);
			Console.WriteLine("Faculties saved to faculties.json.");


		}
		public List<Faculty> StartSession()
		{
			if (File.Exists(@"C:\Users\Victor\source\repos\OOP\Lab1OOP\Faculties.json")) 
			{ 
			string text = File.ReadAllText(@"C:\Users\Victor\source\repos\OOP\Lab1OOP\Faculties.json");
			var faculties = JsonSerializer.Deserialize<List<Faculty>>(text);
				File.Delete(@"C:\Users\Victor\source\repos\OOP\Lab1OOP\Faculties.json");
			return faculties;
			}
			return new List<Faculty>();
        }
	}
}
