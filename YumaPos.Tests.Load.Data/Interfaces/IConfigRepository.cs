using System.Collections.Generic;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Data.Models;

namespace YumaPos.Tests.Load.Client.Data.Interfaces
{
    public interface IConfigRepository
    {
        IEnumerable<Config> GetAll();
        void Save(string key, string value);
    }
}