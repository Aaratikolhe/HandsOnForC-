using Newtonsoft.Json;
namespace ReadJsonFile1
{
    public class Properties
    {
        [JsonProperty("DataString")]
        public string PropertyDataString { get; set; }
        public string value { get; set; }
        public Properties(string propertyDataString, string value)
        {
            PropertyDataString = propertyDataString;
            this.value = value;
        }
    }
}