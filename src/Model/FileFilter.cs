using System.Text;
using System.Text.RegularExpressions;
namespace FileDominator.Model;
public static class FileFilter
{
    public static List<string> FilterFiles(string directory, string pattern)
    {
        List<string> filePaths = new(); 
        var fileNames = Directory.GetFiles(directory, $"*{pattern}*").ToList();
        return fileNames;
    }

    public static List<string> FilterFiles(List<string> directories, List<string> patterns)
    {
        List<string> filePaths = new();

        foreach (var directory in directories)
        {
            foreach (var pattern in patterns)
            {
                filePaths.AddRange(FilterFiles(directory, pattern));
            }
        }
        var nonDuplicatedFiles = filePaths.ToHashSet();
        // Verificar como melhorar esse algoritmo
        return nonDuplicatedFiles.ToList();
    }
}