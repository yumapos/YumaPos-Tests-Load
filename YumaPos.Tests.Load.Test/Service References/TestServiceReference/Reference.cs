﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YumaPos.Tests.Load.Client.TestServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TestServiceReference.ITestService")]
    public interface ITestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/Register", ReplyAction="http://tempuri.org/ITestService/RegisterResponse")]
        System.Guid Register(System.Guid clientId, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/Register", ReplyAction="http://tempuri.org/ITestService/RegisterResponse")]
        System.Threading.Tasks.Task<System.Guid> RegisterAsync(System.Guid clientId, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetTasks", ReplyAction="http://tempuri.org/ITestService/GetTasksResponse")]
        YumaPos.Tests.Load.Infrastucture.Dto.TestTaskDto[] GetTasks(System.Guid clientToken, int maxInstance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/GetTasks", ReplyAction="http://tempuri.org/ITestService/GetTasksResponse")]
        System.Threading.Tasks.Task<YumaPos.Tests.Load.Infrastucture.Dto.TestTaskDto[]> GetTasksAsync(System.Guid clientToken, int maxInstance);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/Report", ReplyAction="http://tempuri.org/ITestService/ReportResponse")]
        void Report(int clientId, [System.ServiceModel.MessageParameterAttribute(Name="report")] YumaPos.Tests.Load.Infrastucture.Dto.ReportDto report1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITestService/Report", ReplyAction="http://tempuri.org/ITestService/ReportResponse")]
        System.Threading.Tasks.Task ReportAsync(int clientId, YumaPos.Tests.Load.Infrastucture.Dto.ReportDto report);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITestServiceChannel : YumaPos.Tests.Load.Client.TestServiceReference.ITestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestServiceClient : System.ServiceModel.ClientBase<YumaPos.Tests.Load.Client.TestServiceReference.ITestService>, YumaPos.Tests.Load.Client.TestServiceReference.ITestService {
        
        public TestServiceClient() {
        }
        
        public TestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Guid Register(System.Guid clientId, string name) {
            return base.Channel.Register(clientId, name);
        }
        
        public System.Threading.Tasks.Task<System.Guid> RegisterAsync(System.Guid clientId, string name) {
            return base.Channel.RegisterAsync(clientId, name);
        }
        
        public YumaPos.Tests.Load.Infrastucture.Dto.TestTaskDto[] GetTasks(System.Guid clientToken, int maxInstance) {
            return base.Channel.GetTasks(clientToken, maxInstance);
        }
        
        public System.Threading.Tasks.Task<YumaPos.Tests.Load.Infrastucture.Dto.TestTaskDto[]> GetTasksAsync(System.Guid clientToken, int maxInstance) {
            return base.Channel.GetTasksAsync(clientToken, maxInstance);
        }
        
        public void Report(int clientId, YumaPos.Tests.Load.Infrastucture.Dto.ReportDto report1) {
            base.Channel.Report(clientId, report1);
        }
        
        public System.Threading.Tasks.Task ReportAsync(int clientId, YumaPos.Tests.Load.Infrastucture.Dto.ReportDto report) {
            return base.Channel.ReportAsync(clientId, report);
        }
    }
}
