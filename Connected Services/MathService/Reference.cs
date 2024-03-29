﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MathService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://TrainingUniqueIdentifier.org/", ConfigurationName="MathService.MathServiceSoap")]
    public interface MathServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Subtract", ReplyAction="*")]
        float Subtract(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<float> SubtractAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Multiply", ReplyAction="*")]
        float Multiply(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<float> MultiplyAsync(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Divide", ReplyAction="*")]
        float Divide(float a, float b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://TrainingUniqueIdentifier.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<float> DivideAsync(float a, float b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public interface MathServiceSoapChannel : MathService.MathServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    public partial class MathServiceSoapClient : System.ServiceModel.ClientBase<MathService.MathServiceSoap>, MathService.MathServiceSoap
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar el punto de conexión de servicio.
        /// </summary>
        /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
        /// <param name="clientCredentials">Credenciales de cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MathServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(MathServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), MathServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MathServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MathServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MathServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int Add(int a, int b)
        {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b)
        {
            return base.Channel.AddAsync(a, b);
        }
        
        public float Subtract(float a, float b)
        {
            return base.Channel.Subtract(a, b);
        }
        
        public System.Threading.Tasks.Task<float> SubtractAsync(float a, float b)
        {
            return base.Channel.SubtractAsync(a, b);
        }
        
        public float Multiply(float a, float b)
        {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<float> MultiplyAsync(float a, float b)
        {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public float Divide(float a, float b)
        {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<float> DivideAsync(float a, float b)
        {
            return base.Channel.DivideAsync(a, b);
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
            if ((endpointConfiguration == EndpointConfiguration.MathServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.MathServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.MathServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44323/MathService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.MathServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44323/MathService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            MathServiceSoap,
            
            MathServiceSoap12,
        }
    }
}
