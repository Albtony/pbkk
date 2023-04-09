using Microsoft.Extensions.Logging;
using BMI_Calculator.Views;
using BMI_Calculator.ViewModels;

namespace BMI_Calculator;

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

		builder.Services.AddTransient<InputPage>();
        builder.Services.AddTransient<InputPageViewModel>();

        builder.Services.AddTransient<BMICalculatorPage>();
        builder.Services.AddTransient<BMICalculatorPageViewModel>();

        builder.Services.AddTransient<BMIListPage>();

        string dbPath = FileAccessHelper.GetLocalFilePath("bmi.db3");
        builder.Services.AddSingleton<BMIRepository>(s => ActivatorUtilities.CreateInstance<BMIRepository>(s, dbPath)); ;
		builder.Services.AddTransient<BMIListPage>();	

        return builder.Build();
	}
}
