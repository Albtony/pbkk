using BMI_Calculator.ViewModels;
namespace BMI_Calculator.Views;

public partial class InputPage : ContentPage
{
	public InputPage(InputPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}