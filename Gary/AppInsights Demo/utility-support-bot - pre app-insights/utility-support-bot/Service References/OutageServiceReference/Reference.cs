﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnwAssistBot.OutageServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OutageServiceReference.OutageServiceSoap")]
    public interface OutageServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByPostcode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SearchOutagesByPostcode(string postcode, bool mobile, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByPostcode", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SearchOutagesByPostcodeAsync(string postcode, bool mobile, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByLatLong", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SearchOutagesByLatLong(double latitude, double longitude, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByLatLong", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SearchOutagesByLatLongAsync(double latitude, double longitude, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByLatLongMobile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SearchOutagesByLatLongMobile(double latitude, double longitude, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByLatLongMobile", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SearchOutagesByLatLongMobileAsync(double latitude, double longitude, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByPostcodeMobile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SearchOutagesByPostcodeMobile(string postcode, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchOutagesByPostcodeMobile", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SearchOutagesByPostcodeMobileAsync(string postcode, bool plannedOutages);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOutageInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetOutageInformation(bool current, bool planned, bool future, int Page, int PageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetOutageInformation", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetOutageInformationAsync(bool current, bool planned, bool future, int Page, int PageSize);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OutageServiceSoapChannel : EnwAssistBot.OutageServiceReference.OutageServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OutageServiceSoapClient : System.ServiceModel.ClientBase<EnwAssistBot.OutageServiceReference.OutageServiceSoap>, EnwAssistBot.OutageServiceReference.OutageServiceSoap {
        
        public OutageServiceSoapClient() {
        }
        
        public OutageServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OutageServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OutageServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OutageServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SearchOutagesByPostcode(string postcode, bool mobile, bool plannedOutages) {
            return base.Channel.SearchOutagesByPostcode(postcode, mobile, plannedOutages);
        }
        
        public System.Threading.Tasks.Task<string> SearchOutagesByPostcodeAsync(string postcode, bool mobile, bool plannedOutages) {
            return base.Channel.SearchOutagesByPostcodeAsync(postcode, mobile, plannedOutages);
        }
        
        public string SearchOutagesByLatLong(double latitude, double longitude, bool plannedOutages) {
            return base.Channel.SearchOutagesByLatLong(latitude, longitude, plannedOutages);
        }
        
        public System.Threading.Tasks.Task<string> SearchOutagesByLatLongAsync(double latitude, double longitude, bool plannedOutages) {
            return base.Channel.SearchOutagesByLatLongAsync(latitude, longitude, plannedOutages);
        }
        
        public string SearchOutagesByLatLongMobile(double latitude, double longitude, bool plannedOutages) {
            return base.Channel.SearchOutagesByLatLongMobile(latitude, longitude, plannedOutages);
        }
        
        public System.Threading.Tasks.Task<string> SearchOutagesByLatLongMobileAsync(double latitude, double longitude, bool plannedOutages) {
            return base.Channel.SearchOutagesByLatLongMobileAsync(latitude, longitude, plannedOutages);
        }
        
        public string SearchOutagesByPostcodeMobile(string postcode, bool plannedOutages) {
            return base.Channel.SearchOutagesByPostcodeMobile(postcode, plannedOutages);
        }
        
        public System.Threading.Tasks.Task<string> SearchOutagesByPostcodeMobileAsync(string postcode, bool plannedOutages) {
            return base.Channel.SearchOutagesByPostcodeMobileAsync(postcode, plannedOutages);
        }
        
        public string GetOutageInformation(bool current, bool planned, bool future, int Page, int PageSize) {
            return base.Channel.GetOutageInformation(current, planned, future, Page, PageSize);
        }
        
        public System.Threading.Tasks.Task<string> GetOutageInformationAsync(bool current, bool planned, bool future, int Page, int PageSize) {
            return base.Channel.GetOutageInformationAsync(current, planned, future, Page, PageSize);
        }
    }
}
