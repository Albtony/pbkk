using MyTask.ViewModel;

namespace MyTask;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

