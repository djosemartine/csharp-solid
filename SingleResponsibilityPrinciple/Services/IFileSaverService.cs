using SingleResponsibilityPrinciple.Models;

namespace SingleResponsibilityPrinciple.Services
{
    public interface IFileSaverService
    {
        void SaveToFile(string directoryPath, string fileName, WorkReport report);
    }
}
