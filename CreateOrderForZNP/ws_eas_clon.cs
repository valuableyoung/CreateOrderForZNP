﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net;
using System.Threading.Tasks;

// 
// Этот исходный код был создан с помощью wsdl, версия=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name = "ws_online5", Namespace = "http://easkis5clon")]
public partial class ws_online5clonService : System.Web.Services.Protocols.SoapHttpClientProtocol
{

    private System.Threading.SendOrPostCallback rc_checkworkOperationCompleted;

    private System.Threading.SendOrPostCallback rc_findtovOperationCompleted;

    private System.Threading.SendOrPostCallback rc_loadtovdocOperationCompleted;

    private System.Threading.SendOrPostCallback rc_unloadtovdocOperationCompleted;

    private System.Threading.SendOrPostCallback rc_loadfindocOperationCompleted;

    private System.Threading.SendOrPostCallback rc_unloadfindocOperationCompleted;

    private System.Threading.SendOrPostCallback rc_reservtovdocOperationCompleted;

    private System.Threading.SendOrPostCallback rc_createorderbuyzkptovOperationCompleted;

    private System.Threading.SendOrPostCallback rc_createorderbuyZnpEndWaitOperationCompleted;

   

    //    string Url_1 = "http://EASWEB:8080/ws_online5duplicate/services/easkis5duplicate_ws_online5"

    /// <remarks/>
    public ws_online5clonService(string ConnectionString)
    {
        /*Change Arhipova 28.12.2022 теперь определяем на момент создания объекта куда подключать будем*/
        string st_eas;

        /*Для тестирования на веб сервисе easkis5clon нужно указывать базу Test и вот тут ветка Clon*/
        if (ConnectionString == "")
        {
            st_eas = "";
        }
        else
        {

            if (ConnectionString.ToLower().Contains("clon"))
            {
                st_eas = @"http://SQL3TSRV:8080/ws_online5clon/services/easkis5clon_ws_online5";

            }
            else
            {
                if (ConnectionString.ToLower().Contains("duplicate"))
                {
                    st_eas = @"http://EASWEB:8080/ws_online5duplicate/services/easkis5duplicate_ws_online5";
                }
                else
                {
                    st_eas = @"http://EASWEB:8080/ws_online5/services/easkis5_ws_online5";
                }
            }
        }

        this.Url = st_eas;

    }


    /// <remarks/>
    public event rc_checkworkCompletedEventHandler rc_checkworkCompleted;

    /// <remarks/>
    public event rc_findtovCompletedEventHandler rc_findtovCompleted;

    /// <remarks/>
    public event rc_loadtovdocCompletedEventHandler rc_loadtovdocCompleted;

    /// <remarks/>
    public event rc_unloadtovdocCompletedEventHandler rc_unloadtovdocCompleted;

    /// <remarks/>
    public event rc_loadfindocCompletedEventHandler rc_loadfindocCompleted;

    /// <remarks/>
    public event rc_unloadfindocCompletedEventHandler rc_unloadfindocCompleted;

    /// <remarks/>
    public event rc_reservtovdocCompletedEventHandler rc_reservtovdocCompleted;


  

    /// <remarks/>
    public event rc_createorderbuyZnpEndWaitCompletedEventHandler rc_createorderbuyZnpEndWaitCompleted;

    /// <remarks/>
    public event rc_createorderbuyzkptovCompletedEventHandler rc_createorderbuyzkptovCompleted;




    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_checkworkReturn")]
    public int rc_checkwork()
    {
        object[] results = this.Invoke("rc_checkwork", new object[0]);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_checkwork(System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_checkwork", new object[0], callback, asyncState);
    }

    /// <remarks/>
    public int Endrc_checkwork(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks/>
    public void rc_checkworkAsync()
    {
        this.rc_checkworkAsync(null);
    }

    /// <remarks/>
    public void rc_checkworkAsync(object userState)
    {
        if ((this.rc_checkworkOperationCompleted == null))
        {
            this.rc_checkworkOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_checkworkOperationCompleted);
        }
        this.InvokeAsync("rc_checkwork", new object[0], this.rc_checkworkOperationCompleted, userState);
    }

    private void Onrc_checkworkOperationCompleted(object arg)
    {
        if ((this.rc_checkworkCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_checkworkCompleted(this, new rc_checkworkCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_findtovReturn")]
    public string rc_findtov(string in0, string in1)
    {
        object[] results = this.Invoke("rc_findtov", new object[] {
                    in0,
                    in1});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_findtov(string in0, string in1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_findtov", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_findtov(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_findtovAsync(string in0, string in1)
    {
        this.rc_findtovAsync(in0, in1, null);
    }

    /// <remarks/>
    public void rc_findtovAsync(string in0, string in1, object userState)
    {
        if ((this.rc_findtovOperationCompleted == null))
        {
            this.rc_findtovOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_findtovOperationCompleted);
        }
        this.InvokeAsync("rc_findtov", new object[] {
                    in0,
                    in1}, this.rc_findtovOperationCompleted, userState);
    }

    private void Onrc_findtovOperationCompleted(object arg)
    {
        if ((this.rc_findtovCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_findtovCompleted(this, new rc_findtovCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_loadtovdocReturn")]
    public string rc_loadtovdoc(string in0, string in1)
    {
        object[] results = this.Invoke("rc_loadtovdoc", new object[] {
                    in0,
                    in1});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_loadtovdoc(string in0, string in1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_loadtovdoc", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_loadtovdoc(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_loadtovdocAsync(string in0, string in1)
    {
        this.rc_loadtovdocAsync(in0, in1, null);
    }

    /// <remarks/>
    public void rc_loadtovdocAsync(string in0, string in1, object userState)
    {
        if ((this.rc_loadtovdocOperationCompleted == null))
        {
            this.rc_loadtovdocOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_loadtovdocOperationCompleted);
        }
        this.InvokeAsync("rc_loadtovdoc", new object[] {
                    in0,
                    in1}, this.rc_loadtovdocOperationCompleted, userState);
    }

    private void Onrc_loadtovdocOperationCompleted(object arg)
    {
        if ((this.rc_loadtovdocCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_loadtovdocCompleted(this, new rc_loadtovdocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_unloadtovdocReturn")]
    public string rc_unloadtovdoc(string in0, string in1)
    {
        object[] results = this.Invoke("rc_unloadtovdoc", new object[] {
                    in0,
                    in1});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_unloadtovdoc(string in0, string in1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_unloadtovdoc", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_unloadtovdoc(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_unloadtovdocAsync(string in0, string in1)
    {
        this.rc_unloadtovdocAsync(in0, in1, null);
    }

    /// <remarks/>
    public void rc_unloadtovdocAsync(string in0, string in1, object userState)
    {
        if ((this.rc_unloadtovdocOperationCompleted == null))
        {
            this.rc_unloadtovdocOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_unloadtovdocOperationCompleted);
        }
        this.InvokeAsync("rc_unloadtovdoc", new object[] {
                    in0,
                    in1}, this.rc_unloadtovdocOperationCompleted, userState);
    }

    private void Onrc_unloadtovdocOperationCompleted(object arg)
    {
        if ((this.rc_unloadtovdocCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_unloadtovdocCompleted(this, new rc_unloadtovdocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_loadfindocReturn")]
    public string rc_loadfindoc(string in0, string in1)
    {
        object[] results = this.Invoke("rc_loadfindoc", new object[] {
                    in0,
                    in1});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_loadfindoc(string in0, string in1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_loadfindoc", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_loadfindoc(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_loadfindocAsync(string in0, string in1)
    {
        this.rc_loadfindocAsync(in0, in1, null);
    }

    /// <remarks/>
    public void rc_loadfindocAsync(string in0, string in1, object userState)
    {
        if ((this.rc_loadfindocOperationCompleted == null))
        {
            this.rc_loadfindocOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_loadfindocOperationCompleted);
        }
        this.InvokeAsync("rc_loadfindoc", new object[] {
                    in0,
                    in1}, this.rc_loadfindocOperationCompleted, userState);
    }

    private void Onrc_loadfindocOperationCompleted(object arg)
    {
        if ((this.rc_loadfindocCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_loadfindocCompleted(this, new rc_loadfindocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_unloadfindocReturn")]
    public string rc_unloadfindoc(string in0, string in1)
    {
        object[] results = this.Invoke("rc_unloadfindoc", new object[] {
                    in0,
                    in1});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_unloadfindoc(string in0, string in1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_unloadfindoc", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_unloadfindoc(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_unloadfindocAsync(string in0, string in1)
    {
        this.rc_unloadfindocAsync(in0, in1, null);
    }

    /// <remarks/>
    public void rc_unloadfindocAsync(string in0, string in1, object userState)
    {
        if ((this.rc_unloadfindocOperationCompleted == null))
        {
            this.rc_unloadfindocOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_unloadfindocOperationCompleted);
        }
        this.InvokeAsync("rc_unloadfindoc", new object[] {
                    in0,
                    in1}, this.rc_unloadfindocOperationCompleted, userState);
    }

    private void Onrc_unloadfindocOperationCompleted(object arg)
    {
        if ((this.rc_unloadfindocCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_unloadfindocCompleted(this, new rc_unloadfindocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_reservtovdocReturn")]
    public string rc_reservtovdoc(string in0, string in1)
    {
        object[] results = this.Invoke("rc_reservtovdoc", new object[] {
                    in0,
                    in1});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_reservtovdoc(string in0, string in1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_reservtovdoc", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_reservtovdoc(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_reservtovdocAsync(string in0, string in1)
    {
        this.rc_reservtovdocAsync(in0, in1, null);
    }

    /// <remarks/>
    public void rc_reservtovdocAsync(string in0, string in1, object userState)
    {
        if ((this.rc_reservtovdocOperationCompleted == null))
        {
            this.rc_reservtovdocOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_reservtovdocOperationCompleted);
        }
        this.InvokeAsync("rc_reservtovdoc", new object[] {
                    in0,
                    in1}, this.rc_reservtovdocOperationCompleted, userState);
    }

    private void Onrc_reservtovdocOperationCompleted(object arg)
    {
        if ((this.rc_reservtovdocCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_reservtovdocCompleted(this, new rc_reservtovdocCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }


    /// <remarks/>
    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_createorderbuyZnpEndWaitReturn")]
    public string rc_createorderbuyZnpEndWait(string in0) { 
        object[] results = this.Invoke("rc_createorderbuyZnpEndWait", new object[] {
                    in0
                    });
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_createorderbuyZnpEndWait(string in0, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_createorderbuyZnpEndWait", new object[] {
                    in0}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_createorderbuyZnpEndWait(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_createorderbuyZnpEndWaitAsync(string in0)
    {
        this.rc_createorderbuyZnpEndWaitAsync(in0);
    }

    /// <remarks/>
    public void rc_createorderbuyZnpEndWaitAsync(string in0,  object userState)
    {
        if ((this.rc_createorderbuyZnpEndWaitOperationCompleted == null))
        {
            this.rc_createorderbuyZnpEndWaitOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_createorderbuyZnpEndWaitOperationCompleted);
        }
        this.InvokeAsync("rc_createorderbuyZnpEndWait", new object[] {
                    in0,
                    }, this.rc_createorderbuyZnpEndWaitOperationCompleted, userState);
    }

    private void Onrc_createorderbuyZnpEndWaitOperationCompleted(object arg)
    {
        if ((this.rc_createorderbuyZnpEndWaitCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_createorderbuyZnpEndWaitCompleted(this, new rc_createorderbuyZnpEndWaitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }

    /// <remarks/>
    public new void CancelAsync(object userState)
    {
        base.CancelAsync(userState);
    }



    [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace = "http://easkis5clon", ResponseNamespace = "http://easkis5clon")]
    [return: System.Xml.Serialization.SoapElementAttribute("rc_createorderbuyzkptovReturn")]
    public string rc_createorderbuyzkptov(string in0, string in1)
    {
        object[] results = this.Invoke("rc_createorderbuyzkptov", new object[] {
                    in0,
                    in1});
        return ((string)(results[0]));
    }

    /// <remarks/>
    public System.IAsyncResult Beginrc_createorderbuyzkptov(string in0, string in1, System.AsyncCallback callback, object asyncState)
    {
        return this.BeginInvoke("rc_createorderbuyzkptov", new object[] {
                    in0,
                    in1}, callback, asyncState);
    }

    /// <remarks/>
    public string Endrc_createorderbuyzkptov(System.IAsyncResult asyncResult)
    {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }

    /// <remarks/>
    public void rc_createorderbuyzkptovAsync(string in0, string in1)
    {
        this.rc_createorderbuyzkptovAsync(in0, in1, null);
    }

    /// <remarks/>
    public void rc_createorderbuyzkptovAsync(string in0, string in1, object userState)
    {
        if ((this.rc_createorderbuyzkptovOperationCompleted == null))
        {
            this.rc_createorderbuyzkptovOperationCompleted = new System.Threading.SendOrPostCallback(this.Onrc_createorderbuyzkptovOperationCompleted);
        }
        this.InvokeAsync("rc_createorderbuyzkptov", new object[] {
                    in0,
                    in1}, this.rc_createorderbuyzkptovOperationCompleted, userState);
    }

    private void Onrc_createorderbuyzkptovOperationCompleted(object arg)
    {
        if ((this.rc_createorderbuyzkptovCompleted != null))
        {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.rc_createorderbuyzkptovCompleted(this, new rc_createorderbuyzkptovCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }




}

[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_createorderbuyzkptovCompletedEventHandler(object sender, rc_createorderbuyzkptovCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_createorderbuyzkptovCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_createorderbuyzkptovCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }



    public static string GetData()
    {
        var url = @"https://arkona36.ru/eolite/settings/eas_server.eas";
        //var result = GetActiveEAS(url);
        var data = GetActiveEAS(url);
        return data.Result;
    }

    public static async Task<string> GetActiveEAS(string url)
    {
        try
        {
            var client = new System.Net.Http.HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var content = await client.GetStringAsync(url);

            //Console.WriteLine(content);
            return content;

        }
        catch (System.Net.Http.HttpRequestException e)
        {
            Console.WriteLine("ошибка :{0} ", e.Message);
            return e.Message;
        }
    }
}



















[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_createorderbuyZnpEndWaitCompletedEventHandler(object sender, rc_createorderbuyZnpEndWaitCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_createorderbuyZnpEndWaitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_createorderbuyZnpEndWaitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }



    public static string GetData()
    {
        var url = @"https://arkona36.ru/eolite/settings/eas_server.eas";
        //var result = GetActiveEAS(url);
        var data = GetActiveEAS(url);
        return data.Result;
    }

    public static async Task<string> GetActiveEAS(string url)
    {
        try
        {
            var client = new System.Net.Http.HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var content = await client.GetStringAsync(url);

            //Console.WriteLine(content);
            return content;

        }
        catch (System.Net.Http.HttpRequestException e)
        {
            Console.WriteLine("ошибка :{0} ", e.Message);
            return e.Message;
        }
    }
}


    



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_checkworkCompletedEventHandler(object sender, rc_checkworkCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_checkworkCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_checkworkCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public int Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((int)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_findtovCompletedEventHandler(object sender, rc_findtovCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_findtovCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_findtovCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_loadtovdocCompletedEventHandler(object sender, rc_loadtovdocCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_loadtovdocCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_loadtovdocCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_unloadtovdocCompletedEventHandler(object sender, rc_unloadtovdocCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_unloadtovdocCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_unloadtovdocCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_loadfindocCompletedEventHandler(object sender, rc_loadfindocCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_loadfindocCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_loadfindocCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_unloadfindocCompletedEventHandler(object sender, rc_unloadfindocCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_unloadfindocCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_unloadfindocCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
public delegate void rc_reservtovdocCompletedEventHandler(object sender, rc_reservtovdocCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class rc_reservtovdocCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

    private object[] results;

    internal rc_reservtovdocCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
    {
        this.results = results;
    }

    /// <remarks/>
    public string Result
    {
        get
        {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }



    public static string GetData()
    {
        var url = @"https://arkona36.ru/eolite/settings/eas_server.eas";
        //var result = GetActiveEAS(url);
        var data = GetActiveEAS(url);
        return data.Result;
    }

    public static async Task<string> GetActiveEAS(string url)
    {
        try
        {
            var client = new System.Net.Http.HttpClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            var content = await client.GetStringAsync(url);

            //Console.WriteLine(content);
            return content;

        }
        catch (System.Net.Http.HttpRequestException e)
        {
            Console.WriteLine("ошибка :{0} ", e.Message);
            return e.Message;
        }
    }
}
















