using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migraitons
{
    public class DirectoryConfigurator
    {
        public static void Replace(string filePath, string oldSubstring, string newSubstring)
        {
            if (File.Exists(filePath) == false) return;

            string input = File.ReadAllText(filePath).Replace(oldSubstring, newSubstring);

            using (FileStream fstream = new(filePath, FileMode.Create))
            {
                byte[] buffer = Encoding.Default.GetBytes(input);
                fstream.Write(buffer, 0, buffer.Length);
            }
        }
        public static List<string> GetAllFiles(List<string> filePaths,  string path)
        {
            if (File.Exists(path) == false) return filePaths;

            string[] files = Directory.GetFiles(path, "*.xml");

            foreach (var file in files)
            {
                filePaths.Add(file);
            }

            string[] dirs = Directory.GetDirectories(path);

            if (dirs.Length == 0)
            {
                return filePaths;
            }
            else
            {
                foreach (var dir in dirs)
                {
                    filePaths = GetAllFiles(filePaths, dir);
                }

                return filePaths;
            }
        }
    }    
}
