namespace DemoProject.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
    }
}
