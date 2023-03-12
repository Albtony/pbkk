namespace PokeMaster;

public partial class PokemonDetailPage : ContentPage
{

    public PokemonDetailPage(PokemonApiResponse pokemon)
    {
        InitializeComponent();
        BindingContext = pokemon;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}