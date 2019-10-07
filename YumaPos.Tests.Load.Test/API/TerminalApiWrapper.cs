using System;
using System.Collections.Generic;
using System.Diagnostics;
using YumaPos.Client.WCF;
using YumaPos.Common.Infrastructure.Common.Serialization;
using YumaPos.FrontEnd.Infrastructure.CommandProcessing;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Shared.Terminal.Infrastructure;
using YumaPos.Tests.Load.Infrastructure.Dto;

namespace YumaPos.Tests.Load.Client.API
{
    public partial class TerminalApiWrapper : ITerminalApi
    {
        private TerminalApi _api;
        private List<ReportItem> _reportItems;


        public TerminalApiWrapper(IAPIConfig config, ISerializationService serializationService, ICheckServerConnectionService checkServerConnectionService)
        {
            _api = new TerminalApi(config, serializationService, checkServerConnectionService);
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

        public TimeSpan MaxInterval { get; set; }
        public TimeSpan MinInterval { get; set; }
    }
}