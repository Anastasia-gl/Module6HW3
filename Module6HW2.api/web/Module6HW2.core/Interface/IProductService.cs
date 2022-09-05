using Module6HW2.db.Model;

namespace Module6HW2.core.Interface
{
    public interface IProductService
    {
        public void Create(Product product);

        public void Delete(int id);

        public void Update(Product product);

        public IList<Product> GetById(int id);
    }
}
