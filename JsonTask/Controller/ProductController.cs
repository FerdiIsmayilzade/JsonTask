using JsonTask.Services;

namespace JsonTask.Controller
{
    internal class ProductController
    {
        private ProductService _service;

        public ProductController()
        {
            _service = new ProductService();
        }

        public void GetProducts()
        {
            var products=_service.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.Name+" "+ product.Price+" "+ product.Count);
                
            }
        }

        public void SearchText(string text)
        {
            var products= _service.SearchText(text);
            foreach (var product in products)
            {
                if (product.Name.Contains(Console.ReadLine()))
                {
                    Console.WriteLine($"Id:{product.Id} Name:{product.Name} Price:{product.Price} Count:{product.Count}");

                }

            }
        }


    }
}
