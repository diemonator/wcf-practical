﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Webshop.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/Service.Models")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/Service.Models")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime MomentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Moment {
            get {
                return this.MomentField;
            }
            set {
                if ((this.MomentField.Equals(value) != true)) {
                    this.MomentField = value;
                    this.RaisePropertyChanged("Moment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IWebshop", CallbackContract=typeof(Webshop.ServiceReference.IWebshopCallback))]
    public interface IWebshop {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/GetWebshopName", ReplyAction="http://tempuri.org/IWebshop/GetWebshopNameResponse")]
        string GetWebshopName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/GetWebshopName", ReplyAction="http://tempuri.org/IWebshop/GetWebshopNameResponse")]
        System.Threading.Tasks.Task<string> GetWebshopNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/GetProductList", ReplyAction="http://tempuri.org/IWebshop/GetProductListResponse")]
        System.Collections.Generic.List<Webshop.ServiceReference.Item> GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/GetProductList", ReplyAction="http://tempuri.org/IWebshop/GetProductListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Webshop.ServiceReference.Item>> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/GetProductInfo", ReplyAction="http://tempuri.org/IWebshop/GetProductInfoResponse")]
        string GetProductInfo(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/GetProductInfo", ReplyAction="http://tempuri.org/IWebshop/GetProductInfoResponse")]
        System.Threading.Tasks.Task<string> GetProductInfoAsync(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/BuyProduct", ReplyAction="http://tempuri.org/IWebshop/BuyProductResponse")]
        bool BuyProduct(string productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWebshop/BuyProduct", ReplyAction="http://tempuri.org/IWebshop/BuyProductResponse")]
        System.Threading.Tasks.Task<bool> BuyProductAsync(string productId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebshop/Connect")]
        void Connect();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebshop/Connect")]
        System.Threading.Tasks.Task ConnectAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebshop/Disconnect")]
        void Disconnect();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebshop/Disconnect")]
        System.Threading.Tasks.Task DisconnectAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebshopCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebshop/NewClientConnected")]
        void NewClientConnected(int numberOfConnectedClients);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebshop/ProductSold")]
        void ProductSold(Webshop.ServiceReference.Item product);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWebshop/DisconnectedClient")]
        void DisconnectedClient(int numberOfConnectedClients);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWebshopChannel : Webshop.ServiceReference.IWebshop, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebshopClient : System.ServiceModel.DuplexClientBase<Webshop.ServiceReference.IWebshop>, Webshop.ServiceReference.IWebshop {
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public WebshopClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string GetWebshopName() {
            return base.Channel.GetWebshopName();
        }
        
        public System.Threading.Tasks.Task<string> GetWebshopNameAsync() {
            return base.Channel.GetWebshopNameAsync();
        }
        
        public System.Collections.Generic.List<Webshop.ServiceReference.Item> GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Webshop.ServiceReference.Item>> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public string GetProductInfo(string productId) {
            return base.Channel.GetProductInfo(productId);
        }
        
        public System.Threading.Tasks.Task<string> GetProductInfoAsync(string productId) {
            return base.Channel.GetProductInfoAsync(productId);
        }
        
        public bool BuyProduct(string productId) {
            return base.Channel.BuyProduct(productId);
        }
        
        public System.Threading.Tasks.Task<bool> BuyProductAsync(string productId) {
            return base.Channel.BuyProductAsync(productId);
        }
        
        public void Connect() {
            base.Channel.Connect();
        }
        
        public System.Threading.Tasks.Task ConnectAsync() {
            return base.Channel.ConnectAsync();
        }
        
        public void Disconnect() {
            base.Channel.Disconnect();
        }
        
        public System.Threading.Tasks.Task DisconnectAsync() {
            return base.Channel.DisconnectAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IShipping", CallbackContract=typeof(Webshop.ServiceReference.IShippingCallback))]
    public interface IShipping {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShipping/GetOrderList", ReplyAction="http://tempuri.org/IShipping/GetOrderListResponse")]
        System.Collections.Generic.List<Webshop.ServiceReference.Order> GetOrderList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShipping/GetOrderList", ReplyAction="http://tempuri.org/IShipping/GetOrderListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<Webshop.ServiceReference.Order>> GetOrderListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShipping/ShipOrder", ReplyAction="http://tempuri.org/IShipping/ShipOrderResponse")]
        bool ShipOrder(int OrderId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShipping/ShipOrder", ReplyAction="http://tempuri.org/IShipping/ShipOrderResponse")]
        System.Threading.Tasks.Task<bool> ShipOrderAsync(int OrderId);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShipping/Subscribe")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShipping/Subscribe")]
        System.Threading.Tasks.Task SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShipping/UnSubscribe")]
        void UnSubscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShipping/UnSubscribe")]
        System.Threading.Tasks.Task UnSubscribeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShippingCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IShipping/OnOrder")]
        void OnOrder(int orderId, string productId, System.DateTime moment);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShippingChannel : Webshop.ServiceReference.IShipping, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShippingClient : System.ServiceModel.DuplexClientBase<Webshop.ServiceReference.IShipping>, Webshop.ServiceReference.IShipping {
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ShippingClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<Webshop.ServiceReference.Order> GetOrderList() {
            return base.Channel.GetOrderList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<Webshop.ServiceReference.Order>> GetOrderListAsync() {
            return base.Channel.GetOrderListAsync();
        }
        
        public bool ShipOrder(int OrderId) {
            return base.Channel.ShipOrder(OrderId);
        }
        
        public System.Threading.Tasks.Task<bool> ShipOrderAsync(int OrderId) {
            return base.Channel.ShipOrderAsync(OrderId);
        }
        
        public void Subscribe() {
            base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public void UnSubscribe() {
            base.Channel.UnSubscribe();
        }
        
        public System.Threading.Tasks.Task UnSubscribeAsync() {
            return base.Channel.UnSubscribeAsync();
        }
    }
}
