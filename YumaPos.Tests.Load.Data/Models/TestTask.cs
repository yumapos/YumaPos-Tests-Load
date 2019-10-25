using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using YumaPos.Shared.Attributes;

namespace YumaPos.Tests.Load.Client.Data.Models
{
    [Map]
    public class TestTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskId { get; set; }
        public int JobId { get; set; }
        public string AuthorizationAddress { get; set; }
        public string ServiceAddress { get; set; }
        public string TenantAlias { get; set; }
        public Guid StoreId { get; set; }
        public Guid TerminalId { get; set; }
        public Guid TerminalToken { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeePassword { get; set; }
        public DateTime Start { get; set; }
        public Int64 DurationTicks { get; set; }
        [NotMapped]
        public TimeSpan Duration
        {
            get { return TimeSpan.FromTicks(DurationTicks); }
            set { DurationTicks = value.Ticks; }
        }
        public Int64 MinIntervalTicks { get; set; }
        [NotMapped]
        public TimeSpan MinInterval
        {
            get { return TimeSpan.FromTicks(MinIntervalTicks); }
            set { MinIntervalTicks = value.Ticks; }
        }
        public Int64 MaxIntervalTicks { get; set; }
        [NotMapped]
        public TimeSpan MaxInterval
        {
            get { return TimeSpan.FromTicks(MaxIntervalTicks); }
            set { MaxIntervalTicks = value.Ticks; }
        }
        public bool IsStarting { get; set; }

        [NotMapped]
        public string[] Scenarios { get; set; }
        public string ScenariosStr
        {
            get { return string.Join(",", Scenarios); }
            set { Scenarios = value.Split(','); }
        }

        public bool ClientIsRegistered { get; set; }
    }
}