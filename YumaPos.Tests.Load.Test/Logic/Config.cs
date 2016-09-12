using System;
using System.Threading.Tasks;
using YumaPos.Tests.Load.Client.Data.Interfaces;
using YumaPos.Tests.Load.Client.Interfaces;

namespace YumaPos.Tests.Load.Client.Logic
{
    public class Config:IConfig
    {
        private readonly IConfigRepository _configRepository;
        private bool _clientIsRegistered = false;
        private Guid _clientId;
        private Guid _clientToken;
        private int _maxInstanceCount = 100;

        public Config(IConfigRepository configRepository)
        {
            _configRepository = configRepository;
            Load();
            if (ClientId == Guid.Empty) ClientId = Guid.NewGuid();
        }

        public void Load()
        {
            var configs = _configRepository.GetAll();
            foreach (var config in configs)
            {
                switch (config.Key)
                {
                    case "ClientIsRegistered":
                        _clientIsRegistered = Boolean.Parse(config.Value);
                        break;
                    case "ClientId":
                        _clientId = Guid.Parse(config.Value);
                        break;
                    case "ClientToken":
                        _clientToken = Guid.Parse(config.Value);
                        break;
                    case "MaxInstanceCount":
                        _maxInstanceCount = int.Parse(config.Value);
                        break;
                }
            }
        }

        public bool ClientIsRegistered
        {
            get { return _clientIsRegistered; }
            set
            {
                _clientIsRegistered = value;
                _configRepository.Save("ClientIsRegistered", value.ToString());
            }
        }

        public Guid ClientId
        {
            get { return _clientId; }
            set
            {
                _clientId = value;
                _configRepository.Save("ClientId", value.ToString());
            }
        }

        public Guid ClientToken
        {
            get { return _clientToken; }
            set
            {
                _clientToken = value;
                _configRepository.Save("ClientToken", value.ToString());
            }
        }

        public int MaxInstanceCount
        {
            get { return _maxInstanceCount; }
            set
            {
                _maxInstanceCount = value;
                _configRepository.Save("MaxInstanceCount", value.ToString());
            }
        }
    }
}