using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.DTOs.CatalogDTOs
{
    public class CatalogDTO
    {
        public int Catalog_Id { get; set; }
        public string Catalog_name { get; set; }
        public string Catalog_description { get; set; }
        public List<string> Productsname { get; set; }
    }
}
