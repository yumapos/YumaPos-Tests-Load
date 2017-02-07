using System;
using System.Collections.Generic;
using System.Diagnostics;
using YumaPos.Client.WCF;
using YumaPos.FrontEnd.Infrastructure.CommandProcessing;
using YumaPos.FrontEnd.Infrastructure.Common.Serialization;
using YumaPos.Shared.Core.Reciept.Contracts;
using YumaPos.Tests.Load.Infrastucture.Dto;

namespace YumaPos.Tests.Load.Client.API
{
    public partial class OrderApiWrapper : YumaPos.Shared.Infrastructure.IOrderServiceApi
    {
        private OrderServiceApi _api;
        private List<ReportItem> _reportItems;


        public OrderApiWrapper(IAPIConfig config, ISerializationService serializationService)
        {
            _api = new OrderServiceApi(config, serializationService);
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