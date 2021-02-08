using System;
using System.Collections.Generic;

namespace FruitList.Domain.Fruits
{
    public class Fruit
    {
        public Fruit() { }

        public string Name { get; set; }

        public string Origin { get; set; }

        public string ImageURL { get; set; }

        public decimal Price { get; set; }

        public bool Like { get; set; }
    }
}