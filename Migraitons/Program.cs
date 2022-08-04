using Migraitons;
using System.Diagnostics;

//correct will be work with 

Stopwatch stopwatch = new Stopwatch();

string mainPath = @"D:\Desktop\_OLD_Configs\_OLD_Configs\98"; //change to your projects configs folder
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
    stopwatch.Start();
    var lastTime = stopwatch.ElapsedMilliseconds;
    foreach (var file in files)
    {
        Console.WriteLine("\t" + file);
        DirectoryConfigurator.Replace(file, "Read GV", "Read GVSr");
        DirectoryConfigurator.Replace(file, "Write GV", "Write GVSr");
        DirectoryConfigurator.Replace(file, "Poll GV", "Poll GVSr");
        DirectoryConfigurator.Replace(file, "GVar", "GVarSr");
    }
    stopwatch.Stop();

    Console.WriteLine("\tFINISHED. Duration: " + (stopwatch.ElapsedMilliseconds - lastTime) + " ms.");
}

Console.WriteLine("All finished. Duration: " + stopwatch.ElapsedMilliseconds);

