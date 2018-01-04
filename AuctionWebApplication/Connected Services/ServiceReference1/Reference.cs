﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuctionItem", Namespace="http://schemas.datacontract.org/2004/07/WCF_AuctionApplication")]
    public partial class AuctionItem : object
    {
        
        private Service1.Bid currentBidField;
        
        private string itemDescriptionField;
        
        private int itemNumberField;
        
        private int ratingPriceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Service1.Bid currentBid
        {
            get
            {
                return this.currentBidField;
            }
            set
            {
                this.currentBidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string itemDescription
        {
            get
            {
                return this.itemDescriptionField;
            }
            set
            {
                this.itemDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int itemNumber
        {
            get
            {
                return this.itemNumberField;
            }
            set
            {
                this.itemNumberField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ratingPrice
        {
            get
            {
                return this.ratingPriceField;
            }
            set
            {
                this.ratingPriceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bid", Namespace="http://schemas.datacontract.org/2004/07/WCF_AuctionApplication")]
    public partial class Bid : object
    {
        
        private string bidCustomNameField;
        
        private string bidCustomPhoneField;
        
        private int bidPriceField;
        
        private System.DateTime bidTimestampField;
        
        private int itemNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bidCustomName
        {
            get
            {
                return this.bidCustomNameField;
            }
            set
            {
                this.bidCustomNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string bidCustomPhone
        {
            get
            {
                return this.bidCustomPhoneField;
            }
            set
            {
                this.bidCustomPhoneField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int bidPrice
        {
            get
            {
                return this.bidPriceField;
            }
            set
            {
                this.bidPriceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime bidTimestamp
        {
            get
            {
                return this.bidTimestampField;
            }
            set
            {
                this.bidTimestampField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int itemNumber
        {
            get
            {
                return this.itemNumberField;
            }
            set
            {
                this.itemNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service1.IAuctionService")]
    public interface IAuctionService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAllAuctionItems", ReplyAction="http://tempuri.org/IAuctionService/GetAllAuctionItemsResponse")]
        System.Threading.Tasks.Task<Service1.AuctionItem[]> GetAllAuctionItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/GetAuctionItem", ReplyAction="http://tempuri.org/IAuctionService/GetAuctionItemResponse")]
        System.Threading.Tasks.Task<Service1.AuctionItem> GetAuctionItemAsync(int itemNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/CreateAuctionItem", ReplyAction="http://tempuri.org/IAuctionService/CreateAuctionItemResponse")]
        System.Threading.Tasks.Task CreateAuctionItemAsync(int itemNumber, string itemDescription, int ratingPrice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionService/ProvideBid", ReplyAction="http://tempuri.org/IAuctionService/ProvideBidResponse")]
        System.Threading.Tasks.Task<bool> ProvideBidAsync(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IAuctionServiceChannel : Service1.IAuctionService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class AuctionServiceClient : System.ServiceModel.ClientBase<Service1.IAuctionService>, Service1.IAuctionService
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AuctionServiceClient() : 
                base(AuctionServiceClient.GetDefaultBinding(), AuctionServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IAuctionService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuctionServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(AuctionServiceClient.GetBindingForEndpoint(endpointConfiguration), AuctionServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuctionServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AuctionServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuctionServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AuctionServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuctionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<Service1.AuctionItem[]> GetAllAuctionItemsAsync()
        {
            return base.Channel.GetAllAuctionItemsAsync();
        }
        
        public System.Threading.Tasks.Task<Service1.AuctionItem> GetAuctionItemAsync(int itemNumber)
        {
            return base.Channel.GetAuctionItemAsync(itemNumber);
        }
        
        public System.Threading.Tasks.Task CreateAuctionItemAsync(int itemNumber, string itemDescription, int ratingPrice)
        {
            return base.Channel.CreateAuctionItemAsync(itemNumber, itemDescription, ratingPrice);
        }
        
        public System.Threading.Tasks.Task<bool> ProvideBidAsync(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone)
        {
            return base.Channel.ProvideBidAsync(itemNumber, bidPrice, bidCustomName, bidCustomPhone);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAuctionService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAuctionService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50422/AuctionService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AuctionServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IAuctionService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AuctionServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IAuctionService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IAuctionService,
        }
    }
}