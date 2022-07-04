using Newtonsoft.Json;
namespace ReadJsonFile1
{
    public class ProductProgram
    {
        public static void Main(string[] args)
        {

            Product table = new Product()
            {
                ProductId = 1,
                ProductName = "Table",
                ProductDescription = new ProductProperties
                {
                    Color = "Brown",
                    Category = "Furniture",
                    Height = 25,
                    Width = 40
                },
                ProductPrice = 8000,
                ProductQuantity = 5
            };
            SerializeJsonFile(table);
            string JsonFilePath = @"C:\Users\kolh_aar\TrainingMaterial\HandsOnForC#\Product.json";
            Product? product = DeserializeJsonFile(JsonFilePath);
            Console.WriteLine(product.ProductName + " " + product.ProductDescription.Color);
        }
        public static void SerializeJsonFile(Product product)
        {
            string jsonString = JsonConvert.SerializeObject(product);

            string filePath = @"C:\Users\kolh_aar\TrainingMaterial\HandsOnForC#\Product.json";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            using (var fileWrite = new StreamWriter(filePath, true))
            {
                fileWrite.WriteLine(jsonString);
                fileWrite.Close();
            }
        }

        public static Product? DeserializeJsonFile(string path)
        {
            string jsonString = File.ReadAllText(path);
       
            JsonSerializer serializer = new JsonSerializer();

            using (JsonTextReader jsonRead = new JsonTextReader(File.OpenText(path)))
            {
                Product product = (Product)serializer.Deserialize(jsonRead, typeof(Product));
                return product;
            }
        }
    }
}
