﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GregsGrocery.myServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="myServiceReference.myWebServiceSoap")]
    public interface myWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        GregsGrocery.myServiceReference.HelloWorldResponse HelloWorld(GregsGrocery.myServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<GregsGrocery.myServiceReference.HelloWorldResponse> HelloWorldAsync(GregsGrocery.myServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name mySubTotals from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/total", ReplyAction="*")]
        GregsGrocery.myServiceReference.totalResponse total(GregsGrocery.myServiceReference.totalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/total", ReplyAction="*")]
        System.Threading.Tasks.Task<GregsGrocery.myServiceReference.totalResponse> totalAsync(GregsGrocery.myServiceReference.totalRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public GregsGrocery.myServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(GregsGrocery.myServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public GregsGrocery.myServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(GregsGrocery.myServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class totalRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="total", Namespace="http://tempuri.org/", Order=0)]
        public GregsGrocery.myServiceReference.totalRequestBody Body;
        
        public totalRequest() {
        }
        
        public totalRequest(GregsGrocery.myServiceReference.totalRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class totalRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public GregsGrocery.myServiceReference.ArrayOfString mySubTotals;
        
        public totalRequestBody() {
        }
        
        public totalRequestBody(GregsGrocery.myServiceReference.ArrayOfString mySubTotals) {
            this.mySubTotals = mySubTotals;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class totalResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="totalResponse", Namespace="http://tempuri.org/", Order=0)]
        public GregsGrocery.myServiceReference.totalResponseBody Body;
        
        public totalResponse() {
        }
        
        public totalResponse(GregsGrocery.myServiceReference.totalResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class totalResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string totalResult;
        
        public totalResponseBody() {
        }
        
        public totalResponseBody(string totalResult) {
            this.totalResult = totalResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface myWebServiceSoapChannel : GregsGrocery.myServiceReference.myWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class myWebServiceSoapClient : System.ServiceModel.ClientBase<GregsGrocery.myServiceReference.myWebServiceSoap>, GregsGrocery.myServiceReference.myWebServiceSoap {
        
        public myWebServiceSoapClient() {
        }
        
        public myWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public myWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public myWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public myWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GregsGrocery.myServiceReference.HelloWorldResponse GregsGrocery.myServiceReference.myWebServiceSoap.HelloWorld(GregsGrocery.myServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            GregsGrocery.myServiceReference.HelloWorldRequest inValue = new GregsGrocery.myServiceReference.HelloWorldRequest();
            inValue.Body = new GregsGrocery.myServiceReference.HelloWorldRequestBody();
            GregsGrocery.myServiceReference.HelloWorldResponse retVal = ((GregsGrocery.myServiceReference.myWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GregsGrocery.myServiceReference.HelloWorldResponse> GregsGrocery.myServiceReference.myWebServiceSoap.HelloWorldAsync(GregsGrocery.myServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<GregsGrocery.myServiceReference.HelloWorldResponse> HelloWorldAsync() {
            GregsGrocery.myServiceReference.HelloWorldRequest inValue = new GregsGrocery.myServiceReference.HelloWorldRequest();
            inValue.Body = new GregsGrocery.myServiceReference.HelloWorldRequestBody();
            return ((GregsGrocery.myServiceReference.myWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GregsGrocery.myServiceReference.totalResponse GregsGrocery.myServiceReference.myWebServiceSoap.total(GregsGrocery.myServiceReference.totalRequest request) {
            return base.Channel.total(request);
        }
        
        public string total(GregsGrocery.myServiceReference.ArrayOfString mySubTotals) {
            GregsGrocery.myServiceReference.totalRequest inValue = new GregsGrocery.myServiceReference.totalRequest();
            inValue.Body = new GregsGrocery.myServiceReference.totalRequestBody();
            inValue.Body.mySubTotals = mySubTotals;
            GregsGrocery.myServiceReference.totalResponse retVal = ((GregsGrocery.myServiceReference.myWebServiceSoap)(this)).total(inValue);
            return retVal.Body.totalResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GregsGrocery.myServiceReference.totalResponse> GregsGrocery.myServiceReference.myWebServiceSoap.totalAsync(GregsGrocery.myServiceReference.totalRequest request) {
            return base.Channel.totalAsync(request);
        }
        
        public System.Threading.Tasks.Task<GregsGrocery.myServiceReference.totalResponse> totalAsync(GregsGrocery.myServiceReference.ArrayOfString mySubTotals) {
            GregsGrocery.myServiceReference.totalRequest inValue = new GregsGrocery.myServiceReference.totalRequest();
            inValue.Body = new GregsGrocery.myServiceReference.totalRequestBody();
            inValue.Body.mySubTotals = mySubTotals;
            return ((GregsGrocery.myServiceReference.myWebServiceSoap)(this)).totalAsync(inValue);
        }
    }
}
