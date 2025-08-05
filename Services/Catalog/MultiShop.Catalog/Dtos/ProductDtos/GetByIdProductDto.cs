namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class GetByIdProductDto
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryID { get; set; }
    }
}
