using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.DTOs.ProductDTOs;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        OnShoppingContext _context;
        public ProductsController(OnShoppingContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Product> products = _context.Products.ToList();
            List<ProductDTO> productsDTOs = new List<ProductDTO>();
            foreach (var product in products)
            {
                ProductDTO prodDTO = new ProductDTO()
                {
                    Product_Id = product.Id,
                    prod_name = product.Name,
                    prod_desc = product.Description,
                    prod_price = product.Price,
                    prod_amount = product.Amount,
                    category_name = product.catalog.Name

                };
                productsDTOs.Add(prodDTO);
            }
            return Ok(productsDTOs.ToList());
        }
        [HttpGet("{id:int}")]
        public IActionResult Getproduct(int id)
        {
            Product product = _context.Products.Find(id);
            if(product == null) return NotFound();
            else
            {
                ProductDTO prodDTO = new ProductDTO()
                {
                    Product_Id = product.Id,
                    prod_name = product.Name,
                    prod_desc = product.Description,
                    prod_price = product.Price,
                    prod_amount = product.Amount,
                    category_name = product.catalog.Name

                };
                return Ok(prodDTO);
            }
        }
        [HttpGet("{price}")]
        public IActionResult GetProductByPrice(decimal price)
        {
            List<Product> products = _context.Products.Where(p => p.Price == price).ToList();
            List<ProductDTO> prodsDTOs = new List<ProductDTO>();
            if(products.Count == 0) return NoContent();
            else
            {
                foreach(Product prd in products)
                {
                    ProductDTO prodDTO = new ProductDTO()
                    {
                        Product_Id = prd.Id,
                        prod_name = prd.Name,
                        prod_desc = prd.Description,
                        prod_price = prd.Price,
                        prod_amount = prd.Amount,
                        category_name = prd.catalog.Name                       
                    };
                    prodsDTOs.Add(prodDTO);
                }
                return Ok(prodsDTOs.ToList());
            }
        }
        [HttpPost]
        public IActionResult addProduct(ProductAddDTO product)
        {
            if(product == null) return BadRequest();
            Product p = new Product()
            {
                Name = product.FullName,
                Description = product.Description,
                Price = product.Product_price,
                Amount = product.Product_amount,
                CatlId = product.Catalog_id
            };
            if(p.CatlId == 0)
                p.CatlId = null;
          
            _context.Products.Add(p);
            _context.SaveChanges();
            ProductDTO productDTO = new ProductDTO()
            {   
                Product_Id = p.Id,
                prod_name = p.Name,
                prod_desc = p.Description,
                prod_price = p.Price,
                prod_amount = p.Amount,
                category_name = _context.Catalogs.Where(c => c.Id == p.CatlId).Select(n => n.Name).SingleOrDefault(),
            };
            return CreatedAtAction("Getproduct", new { id = p.Id }, productDTO);
        }
        [HttpPut("{id}")]
        public IActionResult updateProduct(int id ,ProductAddDTO updateProduct) 
        {
            if(id <= 0) return BadRequest();
            Product product = _context.Products.Find(id);
            if(product == null) return NotFound($"Product with ID {id} not found.");

            product.Name = updateProduct.FullName;
            product.Description = updateProduct.Description;
            product.Price = updateProduct.Product_price;
            product.Amount = updateProduct.Product_amount;
            product.CatlId = updateProduct.Catalog_id;
            
            if (TryValidateModel(product))
            {
                _context.SaveChanges();
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
            Product product = _context.Products.Where(p => p.Id == id).SingleOrDefault();
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            _context.SaveChanges();
            List<Product> products = _context.Products.ToList();
            List<ProductDTO> productsDTO = new List<ProductDTO>();
            foreach(var productItem in products)
            {
                ProductDTO p = new ProductDTO()
                {
                    Product_Id = productItem.Id,
                    prod_name = productItem.Name,
                    prod_desc = productItem.Description,
                    prod_price = productItem.Price,
                    prod_amount = productItem.Amount,
                    category_name = productItem.catalog.Name
                }; 
                productsDTO.Add(p);
            }
            return Ok(productsDTO.ToList());
        }
    }
}
