
// This application will take command line parameters which will do the following on each directory located where the applciation is run:
//
// Update - change into the directory and do a git pull to retrieve the latest code in each directory
// Restore - in each directory, change into a specified folder and call a batch file passing the "restore" parameter
// Run - in each directory, change into a specified folder and call a batch file passing the "run" parameter
//
// Display a list of warnings any time the specified folder does not exist or the batch file within that folder does not exist
//
// Eventually, the application could take in the parent directory as a parameter or a WPF UI could be added.

using System.Diagnostics;

List<string> DirectoryList = new List<string>();

DirectoryList = GetDirectoryList();
for(int i=DirectoryList.Count-1; i>=0; i--) 
{
    string fqdn = Path.Combine(DirectoryList[i], ".git");
    if(!Directory.Exists(fqdn)) // directory is not a versioned directory
    {
        Console.WriteLine($"Removing Directory { DirectoryList[i] }");
        DirectoryList.RemoveAt(i);
    }
}
Console.WriteLine($"There are { DirectoryList.Count } directories reamining in the list.");
Console.ReadLine();

static List<string> GetDirectoryList()
{
    string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
    location = Path.GetDirectoryName(location);
    string[] dirs = Directory.GetDirectories(location);
    return dirs.ToList();
}






