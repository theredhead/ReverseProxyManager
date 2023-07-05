using ReverseProxyManager.ViewModels;

namespace ReverseProxyManager;

public partial class App : Application
{
    ReverseProxiesViewModel viewModel;

    public App(ReverseProxiesViewModel vm)
	{
		InitializeComponent();
        this.viewModel = vm;
		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        window.Created += (s, e) =>
        {
            viewModel.LoadFromFile();
        };

        window.Destroying += (s, e) =>
        {
            viewModel.SaveToFile();
        };

        return window;
    }
}

