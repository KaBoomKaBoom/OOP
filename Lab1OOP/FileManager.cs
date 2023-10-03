using System.Text.Json;

namespace Lab1OOP
{
	public class FileManager
	{
		public void SaveFacultiesToJson(List<Faculty> facultyList)
		{
			string jsonFileName = "Faculties.json";
			var options = new JsonSerializerOptions
			{
				WriteIndented = true
			};
			// Serialize the list of faculties to JSON
			string jsonString = JsonSerializer.Serialize(facultyList, options);
			// Write the JSON data to a file
			File.WriteAllText(jsonFileName, jsonString);
			Console.WriteLine(@"Faculties saved to Lab1OOP\bin\Debug\net7.0\Faculties.json.");
		}
		public List<Faculty> StartSession()
		{
			string jsonFileName = "Faculties.json";
;			if (File.Exists(jsonFileName)) 
			{ 
			string text = File.ReadAllText(jsonFileName);
			var faculties = JsonSerializer.Deserialize<List<Faculty>>(text);
				File.Delete(jsonFileName);
			return faculties;
			}
			return new List<Faculty>();
        }
	}
}
