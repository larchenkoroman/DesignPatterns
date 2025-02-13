namespace CommandCLI;

public class FileSystemReceiver
{
    public void MakeDirectory(string path)
    {
        Directory.CreateDirectory(path);
    }
    public void ChangeDirectory(string path)
    {
        Directory.SetCurrentDirectory(path);
    }
    private void ListFiles(string path)
    {
        foreach(var file in Directory.GetFiles(path))
        {
            Console.WriteLine(file);
        }
    }
    private void ListFolders(string path)
    {
        foreach(var dir in Directory.GetDirectories(path))
        {
            Console.WriteLine($"""{dir}\""");
        }
    }

    public void ListDirectory(string path)
    {
        ListFolders(path);
        ListFiles(path);
    }

}
