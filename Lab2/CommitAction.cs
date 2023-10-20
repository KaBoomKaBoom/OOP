using System;
namespace Lab2
{
    public class CommitAction
    {
        private static Dictionary<string, FileSnapshot> fileSnapshots = new Dictionary<string, FileSnapshot>();
        private static DateTime snapshotTime = DateTime.Now;
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
