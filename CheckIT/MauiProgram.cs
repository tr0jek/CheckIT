using CheckIT.ViewModels;
using CheckIT.ViewModels.Dashboard;
using CheckIT.Views;
using CheckIT.Views.Dashboard;
using CheckIT.Views.Startup;
using Microsoft.Extensions.Logging;

namespace CheckIT;

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
		//Views
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<DashboardPage>();
		builder.Services.AddSingleton<LoadingPage>();
		//ViewsModels
        builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<LoginPageModel>();
		builder.Services.AddSingleton<DashboardPageModel>();
		builder.Services.AddSingleton<LoadingPageModel>();
		

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
