using System.Collections.Generic;
using System.Linq;
using YumaPos.Tests.Load.Client.Data.Interfaces;
using YumaPos.Tests.Load.Client.Data.Models;

namespace YumaPos.Tests.Load.Client.Data.Repositories
{
    public class ConfigRepository : IConfigRepository
    {
        private readonly TestClientDbContext _dbContext;

        public ConfigRepository(IEntityContainer container)
        {
            _dbContext = container.Context;
        }

        public IEnumerable<Config> GetAll()
        {
            return _dbContext.Configuations.ToList();
        }

        public void Save(string key, string value)
        {
            var config = _dbContext.Configuations.Find(key);
            if (config == null)
            {
                _dbContext.Configuations.Add(
                    new Config()
                    {
                        Key = key,
                        Value = value
                    });
            }
            else
            {
                config.Value = value;
            }
            _dbContext.SaveChanges();
        }
    }
}