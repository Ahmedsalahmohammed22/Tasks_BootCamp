namespace OnlineShopping.DTOs.ProductDTOs
{
    public class ProductDTO
    {
        public int Product_Id { get; set; }
        public string prod_name { get; set; }
        public string prod_desc { get; set; }
        public decimal prod_price { get; set; }
        public int prod_amount { get; set; }
        public string category_name { get; set; }
    }
}
