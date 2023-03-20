using BMI_Calculator.ViewModels;
namespace BMI_Calculator.Views;

public partial class BMICalculatorPage : ContentPage
{
	public BMICalculatorPage(BMICalculatorPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}