﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace FlashCards.ViewModel.Phone.FlashCardsServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FlashCardsServiceReference.IFlashCardService")]
    public interface IFlashCardService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IFlashCardService/UploadFile", ReplyAction="http://tempuri.org/IFlashCardService/UploadFileResponse")]
        System.IAsyncResult BeginUploadFile(FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileContentMessage request, System.AsyncCallback callback, object asyncState);
        
        FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileTokenMessage EndUploadFile(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IFlashCardService/GetFileUri", ReplyAction="http://tempuri.org/IFlashCardService/GetFileUriResponse")]
        System.IAsyncResult BeginGetFileUri(string senderName, string password, System.AsyncCallback callback, object asyncState);
        
        string EndGetFileUri(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadFileContentMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UploadFileContentMessage {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public byte[] FileByteStream;
        
        public UploadFileContentMessage() {
        }
        
        public UploadFileContentMessage(byte[] FileByteStream) {
            this.FileByteStream = FileByteStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UploadFileTokenMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UploadFileTokenMessage {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Password;
        
        public UploadFileTokenMessage() {
        }
        
        public UploadFileTokenMessage(string Password) {
            this.Password = Password;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFlashCardServiceChannel : FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UploadFileCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UploadFileCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetFileUriCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetFileUriCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FlashCardServiceClient : System.ServiceModel.ClientBase<FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService>, FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService {
        
        private BeginOperationDelegate onBeginUploadFileDelegate;
        
        private EndOperationDelegate onEndUploadFileDelegate;
        
        private System.Threading.SendOrPostCallback onUploadFileCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetFileUriDelegate;
        
        private EndOperationDelegate onEndGetFileUriDelegate;
        
        private System.Threading.SendOrPostCallback onGetFileUriCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public FlashCardServiceClient() {
        }
        
        public FlashCardServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FlashCardServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlashCardServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FlashCardServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<UploadFileCompletedEventArgs> UploadFileCompleted;
        
        public event System.EventHandler<GetFileUriCompletedEventArgs> GetFileUriCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService.BeginUploadFile(FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileContentMessage request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUploadFile(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginUploadFile(byte[] FileByteStream, System.AsyncCallback callback, object asyncState) {
            FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileContentMessage inValue = new FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileContentMessage();
            inValue.FileByteStream = FileByteStream;
            return ((FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService)(this)).BeginUploadFile(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileTokenMessage FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService.EndUploadFile(System.IAsyncResult result) {
            return base.Channel.EndUploadFile(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private string EndUploadFile(System.IAsyncResult result) {
            FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileTokenMessage retVal = ((FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService)(this)).EndUploadFile(result);
            return retVal.Password;
        }
        
        private System.IAsyncResult OnBeginUploadFile(object[] inValues, System.AsyncCallback callback, object asyncState) {
            byte[] FileByteStream = ((byte[])(inValues[0]));
            return this.BeginUploadFile(FileByteStream, callback, asyncState);
        }
        
        private object[] OnEndUploadFile(System.IAsyncResult result) {
            string retVal = this.EndUploadFile(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUploadFileCompleted(object state) {
            if ((this.UploadFileCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UploadFileCompleted(this, new UploadFileCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UploadFileAsync(byte[] FileByteStream) {
            this.UploadFileAsync(FileByteStream, null);
        }
        
        public void UploadFileAsync(byte[] FileByteStream, object userState) {
            if ((this.onBeginUploadFileDelegate == null)) {
                this.onBeginUploadFileDelegate = new BeginOperationDelegate(this.OnBeginUploadFile);
            }
            if ((this.onEndUploadFileDelegate == null)) {
                this.onEndUploadFileDelegate = new EndOperationDelegate(this.OnEndUploadFile);
            }
            if ((this.onUploadFileCompletedDelegate == null)) {
                this.onUploadFileCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUploadFileCompleted);
            }
            base.InvokeAsync(this.onBeginUploadFileDelegate, new object[] {
                        FileByteStream}, this.onEndUploadFileDelegate, this.onUploadFileCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService.BeginGetFileUri(string senderName, string password, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetFileUri(senderName, password, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService.EndGetFileUri(System.IAsyncResult result) {
            return base.Channel.EndGetFileUri(result);
        }
        
        private System.IAsyncResult OnBeginGetFileUri(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string senderName = ((string)(inValues[0]));
            string password = ((string)(inValues[1]));
            return ((FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService)(this)).BeginGetFileUri(senderName, password, callback, asyncState);
        }
        
        private object[] OnEndGetFileUri(System.IAsyncResult result) {
            string retVal = ((FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService)(this)).EndGetFileUri(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetFileUriCompleted(object state) {
            if ((this.GetFileUriCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetFileUriCompleted(this, new GetFileUriCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetFileUriAsync(string senderName, string password) {
            this.GetFileUriAsync(senderName, password, null);
        }
        
        public void GetFileUriAsync(string senderName, string password, object userState) {
            if ((this.onBeginGetFileUriDelegate == null)) {
                this.onBeginGetFileUriDelegate = new BeginOperationDelegate(this.OnBeginGetFileUri);
            }
            if ((this.onEndGetFileUriDelegate == null)) {
                this.onEndGetFileUriDelegate = new EndOperationDelegate(this.OnEndGetFileUri);
            }
            if ((this.onGetFileUriCompletedDelegate == null)) {
                this.onGetFileUriCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetFileUriCompleted);
            }
            base.InvokeAsync(this.onBeginGetFileUriDelegate, new object[] {
                        senderName,
                        password}, this.onEndGetFileUriDelegate, this.onGetFileUriCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService CreateChannel() {
            return new FlashCardServiceClientChannel(this);
        }
        
        private class FlashCardServiceClientChannel : ChannelBase<FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService>, FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService {
            
            public FlashCardServiceClientChannel(System.ServiceModel.ClientBase<FlashCards.ViewModel.Phone.FlashCardsServiceReference.IFlashCardService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginUploadFile(FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileContentMessage request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("UploadFile", _args, callback, asyncState);
                return _result;
            }
            
            public FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileTokenMessage EndUploadFile(System.IAsyncResult result) {
                object[] _args = new object[0];
                FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileTokenMessage _result = ((FlashCards.ViewModel.Phone.FlashCardsServiceReference.UploadFileTokenMessage)(base.EndInvoke("UploadFile", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginGetFileUri(string senderName, string password, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = senderName;
                _args[1] = password;
                System.IAsyncResult _result = base.BeginInvoke("GetFileUri", _args, callback, asyncState);
                return _result;
            }
            
            public string EndGetFileUri(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("GetFileUri", _args, result)));
                return _result;
            }
        }
    }
}
