﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webservices.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addition", ReplyAction="*")]
        int addition(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addition", ReplyAction="*")]
        System.Threading.Tasks.Task<int> additionAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/subtraction", ReplyAction="*")]
        int subtraction(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/subtraction", ReplyAction="*")]
        System.Threading.Tasks.Task<int> subtractionAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplication", ReplyAction="*")]
        int multiplication(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplication", ReplyAction="*")]
        System.Threading.Tasks.Task<int> multiplicationAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/division", ReplyAction="*")]
        int division(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/division", ReplyAction="*")]
        System.Threading.Tasks.Task<int> divisionAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : webservices.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<webservices.ServiceReference1.WebServiceSoap>, webservices.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int addition(int a, int b) {
            return base.Channel.addition(a, b);
        }
        
        public System.Threading.Tasks.Task<int> additionAsync(int a, int b) {
            return base.Channel.additionAsync(a, b);
        }
        
        public int subtraction(int a, int b) {
            return base.Channel.subtraction(a, b);
        }
        
        public System.Threading.Tasks.Task<int> subtractionAsync(int a, int b) {
            return base.Channel.subtractionAsync(a, b);
        }
        
        public int multiplication(int a, int b) {
            return base.Channel.multiplication(a, b);
        }
        
        public System.Threading.Tasks.Task<int> multiplicationAsync(int a, int b) {
            return base.Channel.multiplicationAsync(a, b);
        }
        
        public int division(int a, int b) {
            return base.Channel.division(a, b);
        }
        
        public System.Threading.Tasks.Task<int> divisionAsync(int a, int b) {
            return base.Channel.divisionAsync(a, b);
        }
    }
}
