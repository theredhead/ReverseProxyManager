using Microsoft.Extensions.Logging;
using ReverseProxyManager.Pages;
using ReverseProxyManager.ViewModels;

namespace ReverseProxyManager
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				});

	#if DEBUG
			builder.Logging.AddDebug();
	#endif

			builder.Services.AddSingleton<ReverseProxiesViewModel>();
			builder.Services.AddSingleton<ProxiesListPage>();
			builder.Services.AddSingleton<ProxyDetailPage>();

			Routing.RegisterRoute(nameof(ProxiesListPage), typeof(ProxiesListPage));
			Routing.RegisterRoute(nameof(ProxyDetailPage), typeof(ProxyDetailPage));


			return builder.Build();
		}
	}
}
