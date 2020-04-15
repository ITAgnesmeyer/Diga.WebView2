using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;


namespace Diga.WebView2.Wrapper
{
    public class WebView2Control : IDisposable
    {
        public event EventHandler Created;
        public event EventHandler<BeforeCreateEventArgs> BeforeCreate;
        public event EventHandler<NavigationStartingEventArgs> NavigateStart;
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public event EventHandler<SourceChangedEventArgs> SourceChanged;
        public event EventHandler<WebView2EventArgs> HistoryChanged;
        public event EventHandler<NavigationCompletedEventArgs> NavigationCompleted;
        private WebView2Settings _Settings;

        public WebView2Control(IntPtr parentHandle) : this(parentHandle, string.Empty, string.Empty, string.Empty)
        {

        }
        public WebView2Control(IntPtr parentHandle, string browserExecutableFolder, string userDataFolder, string additionalBrowserArguments)
        {
            this.ParentHandle = parentHandle;
            this.BrowserExecutableFolder = browserExecutableFolder;
            this.UserDataFolder = userDataFolder;
            this.AdditionalBrowserArguments = additionalBrowserArguments;
            CreateWebView();
        }

        private IntPtr ParentHandle { get; set; }
        public string BrowserExecutableFolder { get; }
        public string UserDataFolder { get; }
        public string AdditionalBrowserArguments { get; }
        private void CreateWebView()
        {
            var handler = new CoreWebView2CreateCoreWebView2EnvironmentCompletedHandler(this.ParentHandle);
            handler.HostCompleted += OnHostCompleted;
            handler.BeforeEnvironmentCompleted += OnBeforeEnvironmentCompleted;
            handler.AfterEnvironmentCompleted += OnAfterEnvironmentCompleted;
            handler.PrepareHostCreate += OnBeforeHostCreate;
            string browserInfo;
            Native.GetCoreWebView2BrowserVersionInfo(this.BrowserExecutableFolder, out browserInfo);

            Native.CreateCoreWebView2EnvironmentWithDetails(this.BrowserExecutableFolder, this.UserDataFolder, this.AdditionalBrowserArguments, handler);
            //handler.HostCompleted-=OnHostCompleted;
            //handler.BeforeEnvironmentCompleted-=OnBeforeEnvironmentCompleted;
            //handler.AfterEnvironmentCompleted-=OnAfterEnvironmentCompleted;
            //handler.PrepareHostCreate-= OnBeforeHostCreate;
        }

        private void OnBeforeHostCreate(object sender, BeforeHostCreateEventArgs e)
        {
            OnBeforeCreate(new BeforeCreateEventArgs(e.Settings));
        }

        private void OnAfterEnvironmentCompleted(object sender, EnvironmentCompletedHandlerArgs e)
        {

        }

        private void OnBeforeEnvironmentCompleted(object sender, EnvironmentCompletedHandlerArgs e)
        {

        }

        private void OnHostCompleted(object sender, CoreWebView2HostCompletedArgs e)
        {
            this.Host = new WebView2Host( e.Host);
            
            this.WebView = new WebView2View( e.WebView);
            this.WebView.NavigationStarting += OnNavigateStartIntern;
            this.WebView.ContentLoading += OnContentLoadingIntern;
            this.WebView.SourceChanged += OnSourceChangedInternal;
            this.WebView.HistoryChanged += OnHistoryChangedInternal;
            this.WebView.NavigationCompleted+= OnNavigationCompletedInternal;
            this._Settings = new WebView2Settings(this.WebView.Settings);
            OnCreated();
        }

        private void OnNavigationCompletedInternal(object sender, NavigationCompletedEventArgs e)
        {
            OnNavigationCompleted(e);
        }

        private void OnHistoryChangedInternal(object sender, WebView2EventArgs e)
        {
            OnHistoryChanged(e);
        }

        private void OnSourceChangedInternal(object sender, SourceChangedEventArgs e)
        {
            OnSourceChanged(e);
        }

        private void OnContentLoadingIntern(object sender, ContentLoadingEventArgs e)
        {
            OnContentLoading(e);
        }

        private void OnNavigateStartIntern(object sender, NavigationStartingEventArgs e)
        {
            OnNavigateStart(e);
        }

        private WebView2View WebView
        {
            get;
            set;
        }

        private WebView2Host Host { get; set; }

        public void DockToParent()
        {
            tagRECT rect;
            Native.GetClientRect(this.ParentHandle, out rect);
            this.Host.Bounds = rect;
        }

        public void Navigate(string url)
        {
            
                this.WebView.Navigate(url);
            

        }

        public void NavigateToString(string htmlContent)
        {
            this.WebView.NavigateToString(htmlContent);

        }

        public void GoBack()
        {
            this.WebView.GoBack();

        }

        public void GoForward()
        {
            this.WebView.GoForward();

        }

        public void Reload()
        {
            this.WebView.Reload();
        }
        public bool CanGoBack => this.WebView.CanGoBack;
        public bool CanGoForward => this.WebView.CanGoForward;
        public string DocumentTitle => this.WebView.DocumentTitle;
        public WebView2Settings Settings => this._Settings;

        public string Source => this.WebView.Source;

        public void Dispose()
        {
            this.Host?.Close();
        }

        protected virtual void OnCreated()
        {
            Created?.Invoke(this, EventArgs.Empty);

        }

        protected virtual void OnBeforeCreate(BeforeCreateEventArgs e)
        {
            BeforeCreate?.Invoke(this, e);
        }

        protected virtual void OnNavigateStart(NavigationStartingEventArgs e)
        {
            NavigateStart?.Invoke(this, e);
        }

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
        }

        protected virtual void OnSourceChanged(SourceChangedEventArgs e)
        {
            SourceChanged?.Invoke(this, e);
        }

        protected virtual void OnHistoryChanged(WebView2EventArgs e)
        {
            HistoryChanged?.Invoke(this, e);
        }

        protected virtual void OnNavigationCompleted(NavigationCompletedEventArgs e)
        {
            NavigationCompleted?.Invoke(this, e);
        }
    }
}