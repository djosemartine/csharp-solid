using SingleResponsibilityPrinciple.Interfaces;

namespace SingleResponsibilityPrinciple.Services
{
    public interface IFileSaverService
    {
        void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> report);
    }
}
