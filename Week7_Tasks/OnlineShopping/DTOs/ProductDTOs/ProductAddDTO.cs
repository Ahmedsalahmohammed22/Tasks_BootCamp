namespace OnlineShopping.DTOs.ProductDTOs
{
    public class ProductAddDTO
    {
        public string FullName { get; set; }
        public string Description { get; set; }
        public decimal Product_price { get; set; }
        public int Product_amount { get; set; }
        public int Catalog_id { get; set; }
        public IFormFile Photo { get; set; }
    }
}
