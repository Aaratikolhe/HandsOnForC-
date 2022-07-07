namespace ReadJsonFile1
{
    public class PossibleActions
    {
        public string Name { get; set; }
        public List<Properties> Properties { get; set; }
        public PossibleActions(string name, List<Properties> properties)
        {
            Name = name;
            Properties = properties;
        }
    }
}