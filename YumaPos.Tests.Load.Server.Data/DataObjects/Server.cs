using System.ComponentModel.DataAnnotations;

namespace YumaPos.Tests.Load.Server.Data.DataObjects
{
    public class Server
    {
        [Key]
        public int ServerId { get; set; }
        public string Name { get; set; }
        public string AuthorizationAddress { get; set; }
        public string ServiceAddress { get; set; }
        public string BackofficeAddress { get; set; }
        public string SqlConnectionString { get; set; }
    }
}