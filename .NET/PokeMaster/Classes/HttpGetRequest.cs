using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class HttpGetRequest
{
    private const string baseUrl = "https://pokeapi.co/api/v2/pokemon";

    public async Task<PokemonApiResponse> GetPokemonAsync(string nameOrId)
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync($"{baseUrl}/{nameOrId}");

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                var pokemonApiResponse = JsonConvert.DeserializeObject<PokemonApiResponse>(responseContent);
                return pokemonApiResponse;
            }
            else
            {
                return null;
            }
        }
    }
}
