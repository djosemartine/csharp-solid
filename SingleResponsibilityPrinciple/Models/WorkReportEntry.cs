using System;

namespace SingleResponsibilityPrinciple.Models
{
    public class WorkReportEntry
    {
        public Guid Id { get; set; }
        public string ProjectCode { get; set; }
        public string Name { get; set; }
        public int SpentHours { get; set; }
        public DateTime DateCreated { get; set; }

        public WorkReportEntry()
        {
            Id = Guid.NewGuid();
            DateCreated = DateTime.UtcNow;
        }
    }
}
