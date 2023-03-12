using Newtonsoft.Json;

public class PokemonApiResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }
    public Sprites Sprites { get; set; }
}

public class Sprites
{
    [JsonProperty("front_default")]
    public string FrontDefault { get; set; }
    [JsonProperty("back_default")]
    public string BackDefault
    {
        get; set;
    }
}