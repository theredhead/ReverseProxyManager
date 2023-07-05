
using System;
using Microsoft.Maui.Controls;
using ReverseProxyManager.ViewModels;

namespace ReverseProxyManager.Pages
{
    public partial class ProxiesListPage : ContentPage
    {
        public ReverseProxiesViewModel ViewModel { get; set; }

        public ProxiesListPage(ReverseProxiesViewModel vm)
        {
            InitializeComponent();
            BindingContext = ViewModel = vm;
        }

        void ItemList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is ReverseProxy proxy)
            {
                ViewModel.SelectedProxy = proxy;
                Shell.Current.GoToAsync(nameof(ProxyDetailPage));
            }
        }

        void AddReverseProxyButton_Clicked(object sender, EventArgs e)
        {
            ViewModel.CreateAndEditNewProxy();
        }

        void Proxies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count() > 0 && e.CurrentSelection[0] is ReverseProxy proxy)
            {
                ViewModel.SelectedProxy = proxy;
                Shell.Current.GoToAsync(nameof(ProxyDetailPage));
            }
        }
    }
}

