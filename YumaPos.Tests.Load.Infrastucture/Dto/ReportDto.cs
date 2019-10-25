using System;
using System.Collections.Generic;
using YumaPos.Shared.Attributes;

namespace YumaPos.Tests.Load.Infrastructure.Dto
{
    [Map]
    public class ReportDto
    {
        public Guid ClientToken { get; set; }
        public int TaskId { get; set; }
        public List<ReportItem> ReportItems { get; set; }
    }

    public class ReportItem
    {
        public string MethodName { get; set; }
        public DateTime Created { get; set; }
        public TimeSpan Duration { get; set; }
        public string ExceptionMessage { get; set; }
    }
}