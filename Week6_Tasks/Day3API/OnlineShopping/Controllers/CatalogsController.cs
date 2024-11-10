using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.DTOs.CatalogDTOs;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        OnShoppingContext _context;
        public CatalogsController(OnShoppingContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Catalog> catalogs = _context.Catalogs.ToList();
            if(catalogs.Count == 0) return NotFound();
            List<CatalogDTO> catalogDTOs = new List<CatalogDTO>();
            foreach(Catalog catalog in catalogs)
            {
                CatalogDTO catalogDTO = new CatalogDTO()
                {
                    Catalog_Id = catalog.Id,
                    Catalog_name = catalog.Name,
                    Catalog_description = catalog.Description,
                    Productsname = catalog.Products.Select(p => p.Name).ToList(),
                };
                catalogDTOs.Add(catalogDTO);
            }
            return Ok(catalogDTOs);
        }
        [HttpGet("{id}")]
        public IActionResult GetCatalog(int id)
        {
            Catalog catalog = _context.Catalogs.Where(c => c.Id == id).SingleOrDefault();
            if(catalog == null) return NotFound();
            CatalogDTO catalogDTO = new CatalogDTO()
            {
                Catalog_Id = catalog.Id,
                Catalog_name = catalog.Name,
                Catalog_description = catalog.Description,
                Productsname = catalog.Products.Select(p => p.Name).ToList()
            };
            return Ok(catalogDTO);
        }
        [HttpPost]

        public IActionResult AddCatalog(AddCatalogDTO addCatalogDTO)
        {
            if(addCatalogDTO == null) return BadRequest();
            Catalog catalog = new Catalog()
            {
                Name = addCatalogDTO.Catalog_name,
                Description = addCatalogDTO.Catalog_description,
            };
            

            if (TryValidateModel(catalog))
            {
                _context.Catalogs.Add(catalog);
                _context.SaveChanges();
                CatalogDTO catalogDTO = new CatalogDTO()
                {
                    Catalog_Id = catalog.Id,
                    Catalog_name = catalog.Name,
                    Catalog_description = catalog.Description,
                    Productsname = catalog.Products.Select(p => p.Name).ToList()
                };
                return CreatedAtAction("GetCatalog", new {id = catalog.Id} ,catalogDTO);
            }else return BadRequest(ModelState);
        }
    }
}
