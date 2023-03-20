using BMI_Calculator.Views;

namespace BMI_Calculator;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(BMICalculatorPage), typeof(BMICalculatorPage));
        Routing.RegisterRoute(nameof(BMIListPage), typeof(BMIListPage));
    }
}
