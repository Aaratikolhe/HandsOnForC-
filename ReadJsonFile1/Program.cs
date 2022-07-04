using Newtonsoft.Json;

namespace ReadJsonFile1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            //string JsonFilePath = @"C:\Users\kolh_aar\TrainingMaterial\HandsOnForC#\MachineStatus.json";
            string JsonFilePath = "MachineStatus.json";
            List<Machine>? machineList = DeserializeJsonFile(JsonFilePath);
            Console.WriteLine("[");
            foreach (Machine machineItem in machineList)
            {
                Console.WriteLine("  {");
                Console.WriteLine("    Name: " + machineItem.Name + " ");
                List<PossibleActions>? possibleActionsList = machineItem.PossibleActions;
                Console.WriteLine("    Possible actions :[");
                foreach (PossibleActions possibleAction in possibleActionsList)
                {
                    Console.WriteLine("\t {\n\t  Name: " + possibleAction.Name);
                    List<Properties>? propertiesList = possibleAction.Properties;
                    Console.WriteLine("\t  Properties: \n\t\t[ ");
                    foreach (Properties property in propertiesList)
                    {
                        Console.WriteLine("\t\tDataString: " + property.PropertyDataString);
                        Console.WriteLine("\t\tValue: " + property.value);
                    }
                    Console.WriteLine("\t\t]\n\t }");
                }
                Console.WriteLine("\t]");
                Console.WriteLine("  }");
            }
            Console.WriteLine("]");


        }
        public static List<Machine>? DeserializeJsonFile(string path)
        {
            string jsonString = File.ReadAllText(path);
            List<Machine>? machineDataList = JsonConvert.DeserializeObject<List<Machine>>(jsonString);
            return machineDataList;
        }
    }

}