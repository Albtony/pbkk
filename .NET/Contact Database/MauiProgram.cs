using Microsoft.Extensions.Logging;
using Contact_Database.Models;
using Contact_Database.ViewModels;
using Contact_Database.Views;
using Windows.Media.Core;

namespace Contact_Database;

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

		builder.Services.AddTransient<InputView>();

		builder.Services.AddTransient<ContactListPage>();
        string dbPath = FileAccessHelper.GetLocalFilePath("bmi.db3");
        builder.Services.AddSingleton<ContactRepository>(s => ActivatorUtilities.CreateInstance<ContactRepository>(s, dbPath));
        builder.Services.AddTransient<InputPageViewModel>();

        return builder.Build();
	}
}

