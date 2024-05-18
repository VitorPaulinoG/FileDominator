using System.Text.RegularExpressions;


namespace FileDominator.Model;
public static class FileRenamer 
{
    public static void RenameWithNewPattern (
        string path, string oldPattern, string newPattern
    )
    {
        string oldFileName = Path.GetFileNameWithoutExtension(path); 
        string newFileName = Regex.Replace(oldFileName, oldPattern, newPattern);
        string newPath = path.Replace(oldFileName, newFileName);
        File.Move(path, newPath);
    }
    public static void RenameWithNewPattern (
        List<string> paths, List<string> oldPatterns, string newPattern
    )
    {
        foreach (var path in paths)
        {
            foreach (var oldPattern in oldPatterns)
            {
                RenameWithNewPattern(path, oldPattern, newPattern);
            }
        }
    }
    public static void RenameWithSuffix (
        string path, string suffix
    )
    {
        string oldFileName = Path.GetFileNameWithoutExtension(path);
        string newFileName = oldFileName + suffix;
        string newPath = path.Replace(oldFileName, newFileName);
        File.Move(path, newPath);
    }
    public static void RenameWithSuffix (List<string> paths, string suffix)
    {
        foreach (var path in paths)
        {
            RenameWithSuffix (path, suffix);
        }
    }
}