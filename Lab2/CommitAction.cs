using System;
namespace Lab2
{
    public class CommitAction
    {
        public  Dictionary<string, FileSnapshot> fileSnapshots = new Dictionary<string, FileSnapshot>();
        public  DateTime snapshotTime = DateTime.Now;

		//need a method to extract from a file into the dictionary
		//need a method to store the changes into the file
        
		public void UpdateSnaphotTime() 
        {
            snapshotTime = DateTime.Now;
            Console.WriteLine("Snapshot time updated to: " + snapshotTime);
            foreach (var pair in fileSnapshots)
            {
                string filename = pair.Key;
                FileSnapshot snapshot = snapshotTime;
                fileSnapshots[filename] = snapshot;
                Console.WriteLine(filename, fileSnapshots[filename]);
            }


        }
    }
}
