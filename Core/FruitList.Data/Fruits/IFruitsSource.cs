using System.Collections.Generic;
using System.Threading.Tasks;
using FruitList.Domain.Fruits;

namespace FruitList.Data.Fruits
{
    public interface IFruitsSource
    {
        Task<IReadOnlyList<Fruit>> GetAll();
    }
}