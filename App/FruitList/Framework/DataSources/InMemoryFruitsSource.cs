using System.Collections.Generic;
using System.Threading.Tasks;
using FruitList.Data.Fruits;
using FruitList.Domain.Fruits;

namespace FruitList.Framework.DataSources
{
    public class InMemoryFruitsSource : IFruitsSource
    {
        public async Task<IReadOnlyList<Fruit>> GetAll()
        {
            await Task.Delay(1000);
            return new List<Fruit>
            {
                new Fruit
                {
                    Name="Lemon",
                    ImageURL="https://bit.ly/3rrEci4",
                    Origin="Ergaud origin",
                    Price=10.00m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Black grapes",
                    ImageURL="https://bit.ly/39U0uTH",
                    Origin="african Beer",
                    Price=12.00m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Indian mango",
                    ImageURL="https://bit.ly/36OrnGq",
                    Origin="fresh indian",
                    Price=12.75m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Banana",
                    ImageURL="https://bit.ly/39T8tQN",
                    Origin="Decaf Colombian",
                    Price=6.50m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Orange",
                    ImageURL="https://bit.ly/2Obk6u0",
                    Origin="Himalayan juicy",
                    Price=0,
                    Like=true,

                },new Fruit
                {
                    Name="Lemon",
                    ImageURL="https://bit.ly/3rrEci4",
                    Origin="Ergaud origin",
                    Price=10.00m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Black grapes",
                    ImageURL="https://bit.ly/39U0uTH",
                    Origin="african Beer",
                    Price=12.00m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Indian mango",
                    ImageURL="https://bit.ly/36OrnGq",
                    Origin="fresh indian",
                    Price=12.75m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Banana",
                    ImageURL="https://bit.ly/39T8tQN",
                    Origin="Decaf Colombian",
                    Price=6.50m,
                    Like=true,

                },
                new Fruit
                {
                    Name="Orange",
                    ImageURL="https://bit.ly/2Obk6u0",
                    Origin="Himalayan juicy",
                    Price=0,
                    Like=true,

                }
            };
        }
    }
}