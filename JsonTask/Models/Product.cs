namespace JsonTask.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Price:{Price} Count:{Count}";
        }
    }
}
