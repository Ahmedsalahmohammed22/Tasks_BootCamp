using OnlineShopping.DTOs.CatalogDTOs;
using OnlineShopping.DTOs.ProductDTOs;
using OnlineShopping.Models;

namespace OnlineShopping.Repository.CatalogReps
{
    public class CatalogFunRepos
    {
        OnShoppingContext _context;
        public CatalogFunRepos(OnShoppingContext context)
        {
            _context = context;

        }
        public CatalogDTO ConvertToCatalogDTO(Catalog catalog)
        {
            CatalogDTO catalogDTO = new CatalogDTO()
            {
                Catalog_Id = catalog.Id,
                Catalog_name = catalog.Name,
                Catalog_description = catalog.Description,
                Productsname = catalog.Products.Select(p => p.Name).ToList(),
            };
            return catalogDTO;
        }
        public List<CatalogDTO> ConvertListOfCatalogssToDTOs(List<Catalog> catalogs)
        {

            List<CatalogDTO> catalogDTOs = new List<CatalogDTO>();
            foreach (Catalog catalog in catalogs)
            {
                CatalogDTO catalogDTO = ConvertToCatalogDTO(catalog);
                catalogDTOs.Add(catalogDTO);
            }
            return catalogDTOs.ToList();
        }
    }
}
