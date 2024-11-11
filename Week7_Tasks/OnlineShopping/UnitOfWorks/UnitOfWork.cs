using OnlineShopping.Models;
using OnlineShopping.Repository;
using OnlineShopping.Repository.CatalogReps;
using OnlineShopping.Repository.ProductReps;


namespace OnlineShopping.UnitOfWorks
{
    public class UnitOfWork
    {
        OnShoppingContext _context;
        GenericRepository<Product> productreps;
        GenericRepository<Catalog> catalogreps;
        ProductFunRepos productFunRepos;
        CatalogFunRepos catalogFunRepos;
        public UnitOfWork(OnShoppingContext context)
        {
            _context = context;
        }
        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (productreps == null)
                    productreps = new GenericRepository<Product>(_context);
                return productreps;
            }
        }
        public GenericRepository<Catalog> CatalogRepository 
        { 
            get
            {
                if(catalogreps == null)
                    catalogreps = new GenericRepository<Catalog>(_context);
                return catalogreps;
            } 
        }
        public ProductFunRepos ProductFunRepos
        {
            get
            {
                if(productFunRepos == null)
                    productFunRepos = new ProductFunRepos(_context);
                return productFunRepos;
            }
        }
        public CatalogFunRepos CatalogFunRepos
        {
            get
            {
                if (catalogFunRepos == null)
                    catalogFunRepos = new CatalogFunRepos(_context);
                return catalogFunRepos;
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
