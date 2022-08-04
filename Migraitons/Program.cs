using Migraitons;

//correct will be work with 

string mainPath = @"D:\Desktop\Projects"; //change to your projects configs folder
string[] projectsPaths = Directory.GetDirectories(mainPath);

for(int i = 0; i < projectsPaths.Length; i++)
{
    projectsPaths[i] += @"\Diagrams"; //change to Diagrams
}

foreach(var projectPath in projectsPaths)
{
    List<string> files = new List<string>();
    DirectoryConfigurator.GetAllFiles(files, projectPath);
    Console.WriteLine(projectPath);
    foreach (var file in files)
    {
        Console.WriteLine("\t" + file);
        DirectoryConfigurator.Replace(file, "Read GV", "Read GVSr");
        DirectoryConfigurator.Replace(file, "Write GV", "Write GVSr");
        DirectoryConfigurator.Replace(file, "Poll GV", "Poll GVSr");
        DirectoryConfigurator.Replace(file, "GVar", "GVarSr");
    }

    Console.WriteLine("\tFINISHED.");
}

Console.WriteLine("All finished.");

