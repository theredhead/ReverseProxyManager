using System;

namespace ReverseProxyManager
{
    public class ReverseProxy
	{
		public Guid Id { get; private set; } = Guid.NewGuid();
		public string Name { get; set; } = "";
		public string InternalUrl { get; set; } = "";
        public string ExternalUrl { get; set; } = "";
        public string Description { get; set; } = "";

        public ReverseProxy()
		{
		}
    }
}


