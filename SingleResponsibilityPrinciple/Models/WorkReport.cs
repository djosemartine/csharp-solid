using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SingleResponsibilityPrinciple.Models
{
    public class WorkReport
    {
        private readonly List<WorkReportEntry> _entries;
        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry workReportEntry)
        {
            _entries.Add(workReportEntry);
        }

        public void RemoveEntryAt(int index)
        {
            _entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.Name}"));
        }
    }
}
