using System;
using ReverseProxyManager.ViewModels;

namespace ReverseProxyManager
{
    public class ReverseProxy : BaseViewModel
	{
		public Guid Id { get; private set; } = Guid.NewGuid();

		string name = "";
		public string Name { get => name; set => SetField(ref name, value); }

		string internalUrl = "";
		public string InternalUrl { get => internalUrl; set => SetField(ref internalUrl, value); }

        string externalUrl = "";
        public string ExternalUrl { get => externalUrl; set => SetField(ref externalUrl, value); }

        string description = "";
        public string Description { get => description; set => SetField(ref description, value); }

        public ReverseProxy()
		{
		}
    }
}
