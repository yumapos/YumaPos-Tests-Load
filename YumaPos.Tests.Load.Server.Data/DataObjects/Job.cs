using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Job
    {

        [Key]
        public int JobId { get; set; }
        public int ServerId { get; set; }

        public string Name { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        public int MaxTenants { get; set; }
        public int MaxStoresPerTenant { get; set; }
        public int MaxTerminalsPerStore { get; set; }
        public TimeSpan MinInterval { get; set; }
        public TimeSpan MaxInterval { get; set; }
        public int MaxTasksCount { get; set; }
        public int TasksCount { get; set; }

        public string ScenariosString { get; set; }

        [NotMapped]
        public string[] Scenarios
        {
            get { return ScenariosString.Split(','); }
            set { ScenariosString = String.Join(",", value); }
        }

        public virtual Server Server { get; set; }
    }

    public class Server
    {
        [Key]
        public int ServerId { get; set; }
        public string AuthorizationAddress { get; set; }
        public string ServiceAddress { get; set; }
        public string DataConnectionString { get; set; }
         
    }
}