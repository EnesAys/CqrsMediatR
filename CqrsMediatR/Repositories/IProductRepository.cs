using CqrsMediatR.Entities;

namespace CqrsMediatR.Repositories
{
    public interface IProductRepository
    {
        public Guid AddProduct(Product product);
        public Product UpdateProduct(Product product);
        public bool DeleteProduct(Guid id);
        public Product GetProductById(Guid id);
        public List<Product> GetAllProducts();
    }
}
