using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FruitList.Data.Fruits;
using FruitList.Domain.Fruits;

namespace FruitList.UseCases.Fruits
{
    public class GetCurrentUserFruits
    {
        private FruitsRepository _fruitsRepository;

        public GetCurrentUserFruits(FruitsRepository fruitsRepository)
        {
            _fruitsRepository = fruitsRepository;
        }

        public Task<IReadOnlyList<Fruit>> Invoke()
        {
            return _fruitsRepository.GetFruitsAsync();
        }
    }
}