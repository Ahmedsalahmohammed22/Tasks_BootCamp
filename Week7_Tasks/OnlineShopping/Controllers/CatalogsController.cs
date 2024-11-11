using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.DTOs.CatalogDTOs;
using OnlineShopping.Models;
using OnlineShopping.UnitOfWorks;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        UnitOfWork _unitOfWork;
        public CatalogsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Catalog> catalogs = _unitOfWork.CatalogRepository.GetAll();
            if(catalogs.Count == 0) return NotFound();
            List<CatalogDTO> catalogDTOs = _unitOfWork.CatalogFunRepos.ConvertListOfCatalogssToDTOs(catalogs);
            return Ok(catalogDTOs);
        }
        [HttpGet("{id}")]
        public IActionResult GetCatalog(int id)
        {
            Catalog catalog = _unitOfWork.CatalogRepository.Get(id);
            if(catalog == null) return NotFound();
            CatalogDTO catalogDTO = _unitOfWork.CatalogFunRepos.ConvertToCatalogDTO(catalog);
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
                _unitOfWork.CatalogRepository.Add(catalog);
                _unitOfWork.Save();
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
