using ExpWithElementsOfMAUI.ViewModels;
using ExpWithElementsOfMAUI.Views;
using Microsoft.Extensions.Logging;

namespace ExpWithElementsOfMAUI;

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
		builder.Services.AddTransient<SecondPage>();
		builder .Services.AddTransient<SecondPageViewModel>();
        builder.Services.AddTransient<CommonPage>();
        builder.Services.AddTransient<CommonPageViewModel>();
        builder.Services.AddTransient<BoshPage>();
		builder.Services.AddTransient<BoshPageViewModel>();
		builder.Services.AddTransient<ModalPage>();
        builder.Services.AddTransient<ModalPageViewModel>();


        return builder.Build();
	}
}
