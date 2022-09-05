using Module6HW2.core.Interface;
using Module6HW2.db.Model;
using AppContext = Module6HW2.db.AppContext;

namespace Module6HW2.infrastructure
{
    public class ProductStore : IProductStore
    {
        private readonly AppContext _appContext;

        public ProductStore(AppContext movieContext)
        {
            _appContext = movieContext;
        }

        public async Task AddAsync(Product product)
        {
            _appContext.Add(product);
            await _appContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var list = _appContext.Product.ToList();
            var index = list.FindIndex(x => x.Id == id);
            _appContext.Remove(list[index]);
            await _appContext.SaveChangesAsync();
        }

        public async Task EditAsync(Product product)
        {
            if (product != null)
            {
                _appContext.Update(product);
            }

            await _appContext.SaveChangesAsync();
        }

        public IList<Product> GetEntityId()
        {
            return _appContext.Product.ToList();
        }
    }
}
