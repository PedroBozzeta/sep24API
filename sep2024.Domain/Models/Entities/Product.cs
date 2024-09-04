namespace sep2024.Domain.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public bool? State { get; set; }
    }
}
