using ReverseProxyManager.ViewModels;

namespace ReverseProxyManager.Pages
{
	public partial class ProxyDetailPage : ContentPage
	{
        public ReverseProxiesViewModel ViewModel { get; set; }

        public ProxyDetailPage(ReverseProxiesViewModel vm)
        {
            InitializeComponent();
            BindingContext = ViewModel = vm;
        }

    }
}

