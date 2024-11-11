using OnlineShopping.DTOs.ProductDTOs;
using OnlineShopping.Models;

namespace OnlineShopping.Repository.ProductReps
{
    public class ProductFunRepos
    {
        OnShoppingContext _context;
        public ProductFunRepos(OnShoppingContext context)
        {
            _context = context;
        }
        public List<Product> GetProductByPrice(decimal price)
        {
            return _context.Products.Where(p => p.Price == price).ToList();
        }
        public ProductDTO ConvertToProductDTO(Product product)
        {
            ProductDTO prodDTO = new ProductDTO()
            {
                Product_Id = product.Id,
                prod_name = product.Name,
                prod_desc = product.Description,
                prod_price = product.Price,
                prod_amount = product.Amount,
                category_name = product.catalog?.Name

            };
            return prodDTO;
        }
        public List<ProductDTO> ConvertListOfProductsToDTOs(List<Product> products)
        {

            List<ProductDTO> productsDTOs = new List<ProductDTO>();
            foreach (var product in products)
            {
                ProductDTO prodDTO = ConvertToProductDTO(product);
                productsDTOs.Add(prodDTO);
            }
            return productsDTOs.ToList();
        }
        public Product UpdateSpecificProduct(Product product , ProductAddDTO updateProduct)
        {

            product.Name = updateProduct.FullName;
            product.Description = updateProduct.Description;
            product.Price = updateProduct.Product_price;
            product.Amount = updateProduct.Product_amount;
            product.CatlId = updateProduct.Catalog_id;

            return product;
        }
    }
}
