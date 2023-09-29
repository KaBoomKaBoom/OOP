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


			string jsonFileName = "Faculties.json";
			string path = Path.Combine(Environment.CurrentDirectory, @"Faculties\", jsonFileName);
			var options = new JsonSerializerOptions
			{
				WriteIndented = true
			};
			// Serialize the list of faculties to JSON
			string jsonString = JsonSerializer.Serialize(facultyList, options);
			// Write the JSON data to a file
			File.WriteAllText(path, jsonString);
			Console.WriteLine("Faculties saved to faculties.json.");
		}
		public List<Faculty> StartSession()
		{
			string jsonFileName = "Faculties.json";
			string path = Path.Combine(Environment.CurrentDirectory, @"Faculties\", jsonFileName);
			if (File.Exists(path)) 
			{ 
			string text = File.ReadAllText(path);
			var faculties = JsonSerializer.Deserialize<List<Faculty>>(text);
				File.Delete(path);
			return faculties;
			}
			return new List<Faculty>();
        }
	}
}
