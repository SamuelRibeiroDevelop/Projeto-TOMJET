﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Este código-fonte foi gerado automaticamente por Microsoft.VSDesigner, Versão 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TOMJETClinete.tomjetcliente {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="tomjetServerSoap", Namespace="http://grupodomeio.org/")]
    public partial class tomjetServer : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback CadastrarVooOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarTodosOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarVooPorIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback TodosVoosDataOrigemDestinoOperationCompleted;
        
        private System.Threading.SendOrPostCallback ComprarBilheteOperationCompleted;
        
        private System.Threading.SendOrPostCallback ConsultarBilhetesOperationCompleted;
        
        private System.Threading.SendOrPostCallback DevolverBilheteOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public tomjetServer() {
            this.Url = global::TOMJETClinete.Properties.Settings.Default.TOMJETClinete_tomjetcliente_tomjetServer;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event CadastrarVooCompletedEventHandler CadastrarVooCompleted;
        
        /// <remarks/>
        public event BuscarTodosCompletedEventHandler BuscarTodosCompleted;
        
        /// <remarks/>
        public event BuscarVooPorIdCompletedEventHandler BuscarVooPorIdCompleted;
        
        /// <remarks/>
        public event TodosVoosDataOrigemDestinoCompletedEventHandler TodosVoosDataOrigemDestinoCompleted;
        
        /// <remarks/>
        public event ComprarBilheteCompletedEventHandler ComprarBilheteCompleted;
        
        /// <remarks/>
        public event ConsultarBilhetesCompletedEventHandler ConsultarBilhetesCompleted;
        
        /// <remarks/>
        public event DevolverBilheteCompletedEventHandler DevolverBilheteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupodomeio.org/CadastrarVoo", RequestNamespace="http://grupodomeio.org/", ResponseNamespace="http://grupodomeio.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo CadastrarVoo(Voo voo) {
            object[] results = this.Invoke("CadastrarVoo", new object[] {
                        voo});
            return ((Voo)(results[0]));
        }
        
        /// <remarks/>
        public void CadastrarVooAsync(Voo voo) {
            this.CadastrarVooAsync(voo, null);
        }
        
        /// <remarks/>
        public void CadastrarVooAsync(Voo voo, object userState) {
            if ((this.CadastrarVooOperationCompleted == null)) {
                this.CadastrarVooOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCadastrarVooOperationCompleted);
            }
            this.InvokeAsync("CadastrarVoo", new object[] {
                        voo}, this.CadastrarVooOperationCompleted, userState);
        }
        
        private void OnCadastrarVooOperationCompleted(object arg) {
            if ((this.CadastrarVooCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CadastrarVooCompleted(this, new CadastrarVooCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupodomeio.org/BuscarTodos", RequestNamespace="http://grupodomeio.org/", ResponseNamespace="http://grupodomeio.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo[] BuscarTodos() {
            object[] results = this.Invoke("BuscarTodos", new object[0]);
            return ((Voo[])(results[0]));
        }
        
        /// <remarks/>
        public void BuscarTodosAsync() {
            this.BuscarTodosAsync(null);
        }
        
        /// <remarks/>
        public void BuscarTodosAsync(object userState) {
            if ((this.BuscarTodosOperationCompleted == null)) {
                this.BuscarTodosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarTodosOperationCompleted);
            }
            this.InvokeAsync("BuscarTodos", new object[0], this.BuscarTodosOperationCompleted, userState);
        }
        
        private void OnBuscarTodosOperationCompleted(object arg) {
            if ((this.BuscarTodosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarTodosCompleted(this, new BuscarTodosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupodomeio.org/BuscarVooPorId", RequestNamespace="http://grupodomeio.org/", ResponseNamespace="http://grupodomeio.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo BuscarVooPorId(int id) {
            object[] results = this.Invoke("BuscarVooPorId", new object[] {
                        id});
            return ((Voo)(results[0]));
        }
        
        /// <remarks/>
        public void BuscarVooPorIdAsync(int id) {
            this.BuscarVooPorIdAsync(id, null);
        }
        
        /// <remarks/>
        public void BuscarVooPorIdAsync(int id, object userState) {
            if ((this.BuscarVooPorIdOperationCompleted == null)) {
                this.BuscarVooPorIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarVooPorIdOperationCompleted);
            }
            this.InvokeAsync("BuscarVooPorId", new object[] {
                        id}, this.BuscarVooPorIdOperationCompleted, userState);
        }
        
        private void OnBuscarVooPorIdOperationCompleted(object arg) {
            if ((this.BuscarVooPorIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarVooPorIdCompleted(this, new BuscarVooPorIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupodomeio.org/TodosVoosDataOrigemDestino", RequestNamespace="http://grupodomeio.org/", ResponseNamespace="http://grupodomeio.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo[] TodosVoosDataOrigemDestino(System.DateTime data, string origem, string destino) {
            object[] results = this.Invoke("TodosVoosDataOrigemDestino", new object[] {
                        data,
                        origem,
                        destino});
            return ((Voo[])(results[0]));
        }
        
        /// <remarks/>
        public void TodosVoosDataOrigemDestinoAsync(System.DateTime data, string origem, string destino) {
            this.TodosVoosDataOrigemDestinoAsync(data, origem, destino, null);
        }
        
        /// <remarks/>
        public void TodosVoosDataOrigemDestinoAsync(System.DateTime data, string origem, string destino, object userState) {
            if ((this.TodosVoosDataOrigemDestinoOperationCompleted == null)) {
                this.TodosVoosDataOrigemDestinoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTodosVoosDataOrigemDestinoOperationCompleted);
            }
            this.InvokeAsync("TodosVoosDataOrigemDestino", new object[] {
                        data,
                        origem,
                        destino}, this.TodosVoosDataOrigemDestinoOperationCompleted, userState);
        }
        
        private void OnTodosVoosDataOrigemDestinoOperationCompleted(object arg) {
            if ((this.TodosVoosDataOrigemDestinoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TodosVoosDataOrigemDestinoCompleted(this, new TodosVoosDataOrigemDestinoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupodomeio.org/ComprarBilhete", RequestNamespace="http://grupodomeio.org/", ResponseNamespace="http://grupodomeio.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Voo ComprarBilhete(int numeroVoo, int quantPassagens) {
            object[] results = this.Invoke("ComprarBilhete", new object[] {
                        numeroVoo,
                        quantPassagens});
            return ((Voo)(results[0]));
        }
        
        /// <remarks/>
        public void ComprarBilheteAsync(int numeroVoo, int quantPassagens) {
            this.ComprarBilheteAsync(numeroVoo, quantPassagens, null);
        }
        
        /// <remarks/>
        public void ComprarBilheteAsync(int numeroVoo, int quantPassagens, object userState) {
            if ((this.ComprarBilheteOperationCompleted == null)) {
                this.ComprarBilheteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnComprarBilheteOperationCompleted);
            }
            this.InvokeAsync("ComprarBilhete", new object[] {
                        numeroVoo,
                        quantPassagens}, this.ComprarBilheteOperationCompleted, userState);
        }
        
        private void OnComprarBilheteOperationCompleted(object arg) {
            if ((this.ComprarBilheteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ComprarBilheteCompleted(this, new ComprarBilheteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupodomeio.org/ConsultarBilhetes", RequestNamespace="http://grupodomeio.org/", ResponseNamespace="http://grupodomeio.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Passagem[] ConsultarBilhetes() {
            object[] results = this.Invoke("ConsultarBilhetes", new object[0]);
            return ((Passagem[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsultarBilhetesAsync() {
            this.ConsultarBilhetesAsync(null);
        }
        
        /// <remarks/>
        public void ConsultarBilhetesAsync(object userState) {
            if ((this.ConsultarBilhetesOperationCompleted == null)) {
                this.ConsultarBilhetesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsultarBilhetesOperationCompleted);
            }
            this.InvokeAsync("ConsultarBilhetes", new object[0], this.ConsultarBilhetesOperationCompleted, userState);
        }
        
        private void OnConsultarBilhetesOperationCompleted(object arg) {
            if ((this.ConsultarBilhetesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsultarBilhetesCompleted(this, new ConsultarBilhetesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://grupodomeio.org/DevolverBilhete", RequestNamespace="http://grupodomeio.org/", ResponseNamespace="http://grupodomeio.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DevolverBilhete(Passagem passagem) {
            this.Invoke("DevolverBilhete", new object[] {
                        passagem});
        }
        
        /// <remarks/>
        public void DevolverBilheteAsync(Passagem passagem) {
            this.DevolverBilheteAsync(passagem, null);
        }
        
        /// <remarks/>
        public void DevolverBilheteAsync(Passagem passagem, object userState) {
            if ((this.DevolverBilheteOperationCompleted == null)) {
                this.DevolverBilheteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDevolverBilheteOperationCompleted);
            }
            this.InvokeAsync("DevolverBilhete", new object[] {
                        passagem}, this.DevolverBilheteOperationCompleted, userState);
        }
        
        private void OnDevolverBilheteOperationCompleted(object arg) {
            if ((this.DevolverBilheteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DevolverBilheteCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupodomeio.org/")]
    public partial class Voo {
        
        private int idVooField;
        
        private int numVooField;
        
        private string aeronaveVooField;
        
        private System.DateTime dataVooField;
        
        private System.DateTime horaVooField;
        
        private string origemVooField;
        
        private string destinoVooField;
        
        private int qtdAssentosVooField;
        
        private double vrUnicoPassagemVooField;
        
        /// <remarks/>
        public int IdVoo {
            get {
                return this.idVooField;
            }
            set {
                this.idVooField = value;
            }
        }
        
        /// <remarks/>
        public int NumVoo {
            get {
                return this.numVooField;
            }
            set {
                this.numVooField = value;
            }
        }
        
        /// <remarks/>
        public string AeronaveVoo {
            get {
                return this.aeronaveVooField;
            }
            set {
                this.aeronaveVooField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DataVoo {
            get {
                return this.dataVooField;
            }
            set {
                this.dataVooField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime HoraVoo {
            get {
                return this.horaVooField;
            }
            set {
                this.horaVooField = value;
            }
        }
        
        /// <remarks/>
        public string OrigemVoo {
            get {
                return this.origemVooField;
            }
            set {
                this.origemVooField = value;
            }
        }
        
        /// <remarks/>
        public string DestinoVoo {
            get {
                return this.destinoVooField;
            }
            set {
                this.destinoVooField = value;
            }
        }
        
        /// <remarks/>
        public int QtdAssentosVoo {
            get {
                return this.qtdAssentosVooField;
            }
            set {
                this.qtdAssentosVooField = value;
            }
        }
        
        /// <remarks/>
        public double VrUnicoPassagemVoo {
            get {
                return this.vrUnicoPassagemVooField;
            }
            set {
                this.vrUnicoPassagemVooField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://grupodomeio.org/")]
    public partial class Passagem {
        
        private int idPassagemField;
        
        private System.DateTime dataPassagemField;
        
        private System.DateTime horaPassagemField;
        
        private double valorPassagemField;
        
        private Voo vooField;
        
        /// <remarks/>
        public int IdPassagem {
            get {
                return this.idPassagemField;
            }
            set {
                this.idPassagemField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime DataPassagem {
            get {
                return this.dataPassagemField;
            }
            set {
                this.dataPassagemField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime HoraPassagem {
            get {
                return this.horaPassagemField;
            }
            set {
                this.horaPassagemField = value;
            }
        }
        
        /// <remarks/>
        public double ValorPassagem {
            get {
                return this.valorPassagemField;
            }
            set {
                this.valorPassagemField = value;
            }
        }
        
        /// <remarks/>
        public Voo Voo {
            get {
                return this.vooField;
            }
            set {
                this.vooField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void CadastrarVooCompletedEventHandler(object sender, CadastrarVooCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CadastrarVooCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CadastrarVooCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void BuscarTodosCompletedEventHandler(object sender, BuscarTodosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarTodosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarTodosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void BuscarVooPorIdCompletedEventHandler(object sender, BuscarVooPorIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarVooPorIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarVooPorIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void TodosVoosDataOrigemDestinoCompletedEventHandler(object sender, TodosVoosDataOrigemDestinoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TodosVoosDataOrigemDestinoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TodosVoosDataOrigemDestinoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void ComprarBilheteCompletedEventHandler(object sender, ComprarBilheteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ComprarBilheteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ComprarBilheteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Voo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Voo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void ConsultarBilhetesCompletedEventHandler(object sender, ConsultarBilhetesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsultarBilhetesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsultarBilhetesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Passagem[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Passagem[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2558.0")]
    public delegate void DevolverBilheteCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591