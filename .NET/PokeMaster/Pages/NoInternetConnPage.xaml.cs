namespace PokeMaster;

public partial class NoInternetConnPage : ContentPage
{
	public NoInternetConnPage()
	{
		InitializeComponent();
	}
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}