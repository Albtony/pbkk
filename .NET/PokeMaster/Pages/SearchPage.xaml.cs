namespace PokeMaster;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}

	private async void OnSearchButtonPressed(object sender, EventArgs e)
	{
		string pokemonName = pokemonSearch.Text;

        if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
		{
			NoInternetConnPage noInternetConnPage= new NoInternetConnPage();
			await Navigation.PushAsync(noInternetConnPage);
			return;
        }
            

        HttpGetRequest httpGetRequest = new HttpGetRequest();
		PokemonApiResponse pokemon = await httpGetRequest.GetPokemonAsync(pokemonName.ToLower());

        PokemonDetailPage pokemonDetailPage = new PokemonDetailPage(pokemon);

        await Navigation.PushAsync(pokemonDetailPage);
    }
}

