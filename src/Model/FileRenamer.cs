using System.Text.RegularExpressions;


namespace FileDominator.Model;
public static class FileRenamer 
{
    public static void RenameWithNewPattern (
        string path, string oldPattern, string newPattern
    )
    {
        string oldFileName = path.Substring(path.LastIndexOf('\\'));
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
}