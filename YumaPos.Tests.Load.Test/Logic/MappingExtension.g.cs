
using System;
using System.Linq;
using YumaPos.Shared.API.Enums;


namespace YumaPos.Tests.Load.Client.Logic 
{
    public static class MapExtensions 
    {
        
        public static YumaPos.Tests.Load.Infrastucture.Dto.ReportDto MapToDto (this YumaPos.Tests.Load.Client.Data.Models.Report item)
        {  
            //itemDo.ReportId
            if (item == null) return null;
            
            var itemDto = new YumaPos.Tests.Load.Infrastucture.Dto.ReportDto ();
                itemDto.TaskId = item.TaskId;

            return itemDto;
        }

        public static YumaPos.Tests.Load.Client.Data.Models.Report MapFromDto (this YumaPos.Tests.Load.Infrastucture.Dto.ReportDto itemDto)
        {  
            if (itemDto == null) return null;
            
            var item = new YumaPos.Tests.Load.Client.Data.Models.Report ();
                item.TaskId = itemDto.TaskId;
            
            return item;
        }
        
        public static YumaPos.Tests.Load.Infrastucture.Dto.TestTaskDto MapToDto (this YumaPos.Tests.Load.Client.Data.Models.TestTask item)
        {  
            //itemDo.DurationTicks
            //itemDo.MinIntervalTicks
            //itemDo.MaxIntervalTicks
            //itemDo.IsStarting
            //itemDo.ScenariosStr
            //itemDo.ClientIsRegistered
            if (item == null) return null;
            
            var itemDto = new YumaPos.Tests.Load.Infrastucture.Dto.TestTaskDto ();
                itemDto.TaskId = item.TaskId;
                itemDto.AuthorizationAddress = item.AuthorizationAddress;
                itemDto.ServiceAddress = item.ServiceAddress;
                itemDto.TenantAlias = item.TenantAlias;
                itemDto.TerminalId = item.TerminalId;
                itemDto.TerminalToken = item.TerminalToken;
                itemDto.EmployeeLogin = item.EmployeeLogin;
                itemDto.EmployeePassword = item.EmployeePassword;
                itemDto.Start = item.Start;
                itemDto.Duration = item.Duration;
                itemDto.MinInterval = item.MinInterval;
                itemDto.MaxInterval = item.MaxInterval;
                itemDto.Scenarios = item.Scenarios;

            return itemDto;
        }

        public static YumaPos.Tests.Load.Client.Data.Models.TestTask MapFromDto (this YumaPos.Tests.Load.Infrastucture.Dto.TestTaskDto itemDto)
        {  
            //itemDto.TerminalIsRegistered
            if (itemDto == null) return null;
            
            var item = new YumaPos.Tests.Load.Client.Data.Models.TestTask ();
                item.TaskId = itemDto.TaskId;
                item.AuthorizationAddress = itemDto.AuthorizationAddress;
                item.ServiceAddress = itemDto.ServiceAddress;
                item.TenantAlias = itemDto.TenantAlias;
                item.TerminalId = itemDto.TerminalId;
                item.TerminalToken = itemDto.TerminalToken;
                item.EmployeeLogin = itemDto.EmployeeLogin;
                item.EmployeePassword = itemDto.EmployeePassword;
                item.Start = itemDto.Start;
                item.Duration = itemDto.Duration;
                item.MinInterval = itemDto.MinInterval;
                item.MaxInterval = itemDto.MaxInterval;
                item.Scenarios = itemDto.Scenarios;
            
            return item;
        }
    
    }
}
