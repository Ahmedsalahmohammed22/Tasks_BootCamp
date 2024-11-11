using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.DTOs.ProductDTOs;
using OnlineShopping.Models;
using OnlineShopping.Repository;
using OnlineShopping.UnitOfWorks;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        UnitOfWork _unitOfWork;
        public ProductsController(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Product> products = _unitOfWork.ProductRepository.GetAll();
            List<ProductDTO> productsDTOs = _unitOfWork.ProductFunRepos.ConvertListOfProductsToDTOs(products);
            return Ok(productsDTOs);
        }
        [HttpGet("{id:int}")]
        public IActionResult Getproduct(int id)
        {
            Product product = _unitOfWork.ProductRepository.Get(id);
            if(product == null) return NotFound();
            else
            {
                ProductDTO prodDTO = _unitOfWork.ProductFunRepos.ConvertToProductDTO(product);
                return Ok(prodDTO);
            }
        }
        [HttpGet("{price}")]
        public IActionResult GetProductByPrice(decimal price)
        {
            List<Product> products = _unitOfWork.ProductFunRepos.GetProductByPrice(price);
            if (products.Count == 0) return NoContent();
            else
            {
                List<ProductDTO> prodsDTOs = _unitOfWork.ProductFunRepos.ConvertListOfProductsToDTOs(products);

                return Ok(prodsDTOs);
            }
        }
        [HttpPost]
        public IActionResult addProduct(ProductAddDTO product)
        {
            if(product == null) return BadRequest();
            String photoPath = Path.Combine(Directory.GetCurrentDirectory(), "UploadFiles" , product.Photo.FileName);
            FileStream file = new FileStream(photoPath , FileMode.Create);
            product.Photo.CopyTo(file);
            Product p = new Product()
            {
                Name = product.FullName,
                Description = product.Description,
                Price = product.Product_price,
                Amount = product.Product_amount,
                CatlId = product.Catalog_id,
                PhotoPath = photoPath,
            };
            if(p.CatlId == 0)
                p.CatlId = null;
            if(TryValidateModel(p))
            {
                _unitOfWork.ProductRepository.Add(p);
                _unitOfWork.Save();
            }
            else {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
           
            ProductDTO productDTO = new ProductDTO()
            {   
                Product_Id = p.Id,
                prod_name = p.Name,
                prod_desc = p.Description,
                prod_price = p.Price,
                prod_amount = p.Amount,
                category_name = _unitOfWork.CatalogRepository.Get((int)p.CatlId).Name
            };
            return CreatedAtAction("Getproduct", new { id = p.Id }, productDTO);
        }
        [HttpPut("{id}")]
        public IActionResult updateProduct(int id ,ProductAddDTO updateProduct) 
        {
            if(id <= 0) return BadRequest();
            Product product = _unitOfWork.ProductRepository.Get(id);
            if(product == null) return NotFound($"Product with ID {id} not found.");
            _unitOfWork.ProductFunRepos.UpdateSpecificProduct(product , updateProduct);
            
            if (TryValidateModel(product))
            {
                _unitOfWork.Save();
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
            
        }
        [HttpDelete("{id}")]
        public IActionResult deleteProduct(int id)
        {
            Product product = _unitOfWork.ProductRepository.Get(id);
            if (product == null) return NotFound();
            _unitOfWork.ProductRepository.Delete(id);
            _unitOfWork.Save();
            List<Product> products = _unitOfWork.ProductRepository.GetAll();
            List<ProductDTO> productsDTO = _unitOfWork.ProductFunRepos.ConvertListOfProductsToDTOs(products);
            return Ok(productsDTO);
        }
    }
}
