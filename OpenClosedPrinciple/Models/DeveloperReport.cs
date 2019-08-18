using System;

namespace OpenClosedPrinciple.Models
{
    public class DeveloperReport
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int WorkingHours { get; set; }
        public double HourlyRate { get; set; }
    }
}
