﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClient.RemoteReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RemoteReference.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/TestConnection", ReplyAction="http://tempuri.org/ICalculator/TestConnectionResponse")]
        string TestConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/TestConnection", ReplyAction="http://tempuri.org/ICalculator/TestConnectionResponse")]
        System.Threading.Tasks.Task<string> TestConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Addition", ReplyAction="http://tempuri.org/ICalculator/AdditionResponse")]
        double Addition(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Addition", ReplyAction="http://tempuri.org/ICalculator/AdditionResponse")]
        System.Threading.Tasks.Task<double> AdditionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction", ReplyAction="http://tempuri.org/ICalculator/SubtractionResponse")]
        double Subtraction(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Subtraction", ReplyAction="http://tempuri.org/ICalculator/SubtractionResponse")]
        System.Threading.Tasks.Task<double> SubtractionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiplication", ReplyAction="http://tempuri.org/ICalculator/MultiplicationResponse")]
        double Multiplication(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiplication", ReplyAction="http://tempuri.org/ICalculator/MultiplicationResponse")]
        System.Threading.Tasks.Task<double> MultiplicationAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division", ReplyAction="http://tempuri.org/ICalculator/DivisionResponse")]
        double Division(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Division", ReplyAction="http://tempuri.org/ICalculator/DivisionResponse")]
        System.Threading.Tasks.Task<double> DivisionAsync(double a, double b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : TestClient.RemoteReference.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<TestClient.RemoteReference.ICalculator>, TestClient.RemoteReference.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TestConnection() {
            return base.Channel.TestConnection();
        }
        
        public System.Threading.Tasks.Task<string> TestConnectionAsync() {
            return base.Channel.TestConnectionAsync();
        }
        
        public double Addition(double a, double b) {
            return base.Channel.Addition(a, b);
        }
        
        public System.Threading.Tasks.Task<double> AdditionAsync(double a, double b) {
            return base.Channel.AdditionAsync(a, b);
        }
        
        public double Subtraction(double a, double b) {
            return base.Channel.Subtraction(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SubtractionAsync(double a, double b) {
            return base.Channel.SubtractionAsync(a, b);
        }
        
        public double Multiplication(double a, double b) {
            return base.Channel.Multiplication(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MultiplicationAsync(double a, double b) {
            return base.Channel.MultiplicationAsync(a, b);
        }
        
        public double Division(double a, double b) {
            return base.Channel.Division(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(double a, double b) {
            return base.Channel.DivisionAsync(a, b);
        }
    }
}