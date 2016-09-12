using System.ComponentModel.DataAnnotations;

namespace YumaPos.Tests.Load.Client.Data.Models
{
    public class Config 
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}