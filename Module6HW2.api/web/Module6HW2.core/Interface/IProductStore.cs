using Module6HW2.db.Model;
namespace Module6HW2.core.Interface
{
    public interface IProductStore
    {
        public Task AddAsync(Product product);

        public Task RemoveAsync(int id);

        public Task EditAsync(Product product);

        public IList<Product> GetEntityId();
    }
}
