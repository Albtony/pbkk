using Newtonsoft.Json;

public class PokemonApiResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    private float _height;
    private float _weight;
    public float Height
    {
        get => _height;
        set => _height = value / 10f;
    }

    public float Weight
    {
        get => _weight;
        set => _weight = value / 10f;
    }
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