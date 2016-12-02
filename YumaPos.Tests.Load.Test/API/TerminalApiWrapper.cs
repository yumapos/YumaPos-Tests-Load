using System.Collections.Generic;
using System.Diagnostics;
using YumaPos.Client.WCF;
using YumaPos.FrontEnd.Infrastructure.CommandProcessing;
using YumaPos.FrontEnd.Infrastructure.Common.Serialization;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Client.API
{
    public partial class TerminalApiWrapper : YumaPos.Shared.Infrastructure.ITerminalApi
    {
        private TerminalApi _api;
        private List<ReportItem> _reportItems;


        public TerminalApiWrapper(IAPIConfig config, ISerializationService serializationService)
        {
            _api = new TerminalApi(config, serializationService);
            _reportItems = new List<ReportItem>();
        }

        public ExecutionContext ExecutionContext
        {
            get { return _api.ExecutionContext; }
            set { _api.ExecutionContext = value; }
        }

        public void SetUserToken(string token)
        {
            _api.SetUserToken(token);
        }

        public List<ReportItem> ReportItems
        {
            get { return _reportItems; }
        }
    }
}