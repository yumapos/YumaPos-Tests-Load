using System;
using System.ComponentModel.DataAnnotations;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public string MethodName { get; set; }
        public DateTime Created { get; set; }
        public TimeSpan Duration { get; set; }
        public string ExceptionMessage { get; set; }
        public int TaskId { get; set; }
        public int JobId { get; set; }

        public virtual Job Job { get; set; }
    }
}