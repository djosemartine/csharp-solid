using SingleResponsibilityPrinciple.Models;
using System.IO;

namespace SingleResponsibilityPrinciple.Services
{
    public class FileSaverService : IFileSaverService
    {
        public void SaveToFile(string directoryPath, string fileName, WorkReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
