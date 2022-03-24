namespace Helloworld.Models
{
    public class Product
    {
        public Product()
        {
            isDelete = false;
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Price { get; set; }
        public bool isDelete { get; set; }

    }
}

