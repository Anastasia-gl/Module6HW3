
using Module6HW2.core.Interface;
using Module6HW2.db.Model;

namespace Module6HW2.core.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductStore _productStore;

        public ProductService(IProductStore productStore)
        {
            _productStore = productStore;
        }
        public void Create(Product product)
        {
            _productStore.AddAsync(product);
        }

        public void Delete(int id)
        {
            _productStore.RemoveAsync(id);
        }

        public void Update(Product product)
        {
            _productStore.EditAsync(product);
        }

        public IList<Product> GetById(int id)
        {
            return _productStore.GetEntityId().Where(t => t.Id == id).ToList();
        }
    }
}
