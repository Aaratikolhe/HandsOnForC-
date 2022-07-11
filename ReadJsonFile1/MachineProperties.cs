using Newtonsoft.Json;
namespace ReadJsonFile1
{
    public class Properties
    {
        //[JsonProperty("DataString")]
        public string PropertyDataString { get; }
        public string value { get; }
        public Properties(string DataString, string value)
        {
            PropertyDataString = DataString;
            this.value = value;
        }
    }
}