using Migraitons;

string[] paths = {
    @"D:\Desktop\C519 FFL\C519 FFL\Diagrams"
    //@"D:\Desktop\98\HCM_Modules\Diagrams",
    //@"D:\Desktop\98\Rework\Diagrams",
    //@"D:\Desktop\98\Tesla Model Y RL\Diagrams"
 };

foreach(var dirPath in paths)
{
    List<string> files = new List<string>();
    DirectoryConfigurator.GetAllFiles(files, dirPath);

    foreach (var file in files)
    {
        DirectoryConfigurator.Replace(file, "Read GV", "Read GVSr");
        DirectoryConfigurator.Replace(file, "Write GV", "Write GVSr");
        DirectoryConfigurator.Replace(file, "Poll GV", "Poll GVSr");
        DirectoryConfigurator.Replace(file, "GVar", "GVarSr");
    }

    Console.WriteLine(dirPath + "\nFinished.");
}

Console.WriteLine("All finished.");

