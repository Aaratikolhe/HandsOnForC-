using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadJsonFile1
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public ProductProperties ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public override string? ToString()
        {
            return $"{ProductId}  {ProductId} {ProductDescription}";
        }
    }
}
