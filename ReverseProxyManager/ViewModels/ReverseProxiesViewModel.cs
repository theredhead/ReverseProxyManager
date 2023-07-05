using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace ReverseProxyManager.ViewModels
{
	public class ReverseProxiesViewModel : BaseViewModel
	{
        ReverseProxy selectedProxy;
        public ReverseProxy SelectedProxy { get => selectedProxy; set => SetField(ref selectedProxy, value); }
        

        ObservableCollection<ReverseProxy> proxies = new ObservableCollection<ReverseProxy>();
        public ObservableCollection<ReverseProxy> Proxies { get => proxies; set => SetField(ref proxies, value); }

        public ReverseProxiesViewModel()
		{
            InitForTesting();
            Console.WriteLine($"Have {proxies.Count()} ReverseProxy instances stored.");
        }

        private void InitForTesting()
        {
            proxies.Add(new ReverseProxy
            {
                Name = "Jenkins",
                Description = "Buildserver",
                InternalUrl = "jenkins.theredhead.local",
                ExternalUrl = "jenkins.theredhead.nl"
            });
            proxies.Add(new ReverseProxy
            {
                Name = "Verdaccio",
                Description = "NPM repository",
                InternalUrl = "verdaccio.theredhead.local",
                ExternalUrl = "verdaccio.theredhead.nl"
            });
            proxies.Add(new ReverseProxy
            {
                Name = "Keycloak",
                Description = "Keycloak authentication server",
                InternalUrl = "keycloak.theredhead.local",
                ExternalUrl = "auth.theredhead.nl"
            });
            proxies.Add(new ReverseProxy
            {
                Name = "www.theredhead.nl",
                Description = "Main webserver",
                InternalUrl = "theredhead_dot_nl.theredhead.local",
                ExternalUrl = "www.theredhead.nl"
            });
            proxies.Add(new ReverseProxy
            {
                Name = "Data",
                Description = "Main database server",
                InternalUrl = "db.theredhead.local",
                ExternalUrl = "db.theredhead.nl"
            });
            proxies.Add(new ReverseProxy
            {
                Name = "Mini",
                Description = "Livingroom mac mini",
                InternalUrl = "mini.theredhead.local",
                ExternalUrl = "mini.theredhead.nl"
            });
            proxies.Add(new ReverseProxy
            {
                Name = "Blog",
                Description = "Wordpress blog",
                InternalUrl = "wp.theredhead.local",
                ExternalUrl = "blog.theredhead.nl"
            });
        }
    }
}

