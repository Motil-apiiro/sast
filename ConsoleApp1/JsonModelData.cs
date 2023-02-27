using Newtonsoft.Json;

namespace ConsoleApp1;

public class JsonModelData
{
    [JsonProperty] 
    public int IdOrName { get; set; }
}