using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1OOP
{
    public class Options
    {
        public string generalOptions(string option) 
        {
            Console.WriteLine("1. cf - Create a new faculty"); //+
            Console.WriteLine("2. fo - Faculty operations"); //+
            Console.WriteLine("3. ssf - Search what faculty a student belongs to by email");//+
            Console.WriteLine("4. df - Display University faculties");//+
            Console.WriteLine("5. dff - Display all faculties belonging to a field");//+
            Console.WriteLine("6. eff - Enroll student from a file");//+
            Console.WriteLine("7. gff - Graduate students fro a file");//+
            Console.WriteLine("8. q - Quit and save");//+
            Console.WriteLine();
            Console.Write("Choose option: ");
            option = Console.ReadLine();
            Console.WriteLine();
            return option;
        }

        public void facultyOptions(List<Faculty> faculties) 
        {
            FacultyOperations facultyOperations=new FacultyOperations();
            Console.WriteLine("1. cs - Create and assign a student to a faculty"); //+
            Console.WriteLine("2. gs - Graduate a student from a faculty");//+
            Console.WriteLine("3. des - Display current enrolled students (Graduates would be ignored)");//+
            Console.WriteLine("4. dgs - Display graduates (Currently enrolled students would be ignored)");//+
            Console.WriteLine("5. sf - Tell or not if a student belongs to this faculty");//+
            Console.WriteLine("6. b - Back");//+
            Console.WriteLine();
            Console.Write("Choose option: ");
            var option = Console.ReadLine();
            switch (option)
            {
                //Create and assign a student to a faculty
                case "cs":
                    facultyOperations.assignStudent(faculties);
                    break;
                //Graduate a student from a faculty
                case "gs":
                    facultyOperations.gradStatus(faculties);
                    break;
                //Display current enrolled students (Graduates would be ignored)
                case "des":
                    facultyOperations.printStudents(faculties, false);
                    break;
                //Display graduates (Currently enrolled students would be ignored)
                case "dgs":
                    facultyOperations.printStudents(faculties, true);
                    break;
                case "sf":
                    facultyOperations.checkSudent(faculties);
                    break;
                case "b":
                    break;
            }
        }
    }
}
