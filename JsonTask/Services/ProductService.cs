using JsonTask.Models;
using Newtonsoft.Json;

namespace JsonTask.Services
{
    internal class ProductService
    {
        const string path = "C:\\Users\\Acer\\OneDrive\\Masaüstü\\CSharp\\JsonTask\\JsonTask\\Product.json";

        public List<Product> GetProducts()
        {
            using(StreamReader sr= new StreamReader(path))
            {
                var list=JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());
                return list ?? new List<Product>();
            }

        }
        public List<Product> SearchText(string text)
        {
            ProductService service = new ProductService();
            var result = service.GetProducts();
            return result;
            
        }
    }
}
