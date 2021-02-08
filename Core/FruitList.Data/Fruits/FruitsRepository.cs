using System.Collections.Generic;
using System.Threading.Tasks;
using FruitList.Domain.Fruits;

namespace FruitList.Data.Fruits
{
    public class FruitsRepository
    {
        private IFruitsSource _fruitsSource;

        public FruitsRepository(IFruitsSource fruitsSource)
        {
            _fruitsSource = fruitsSource;
        }

        public async Task<IReadOnlyList<Fruit>> GetFruitsAsync()
        {
            return await _fruitsSource.GetAll();
        }
    }
}