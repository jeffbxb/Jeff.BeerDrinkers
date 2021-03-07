using System;
using System.Collections.Generic;
using Jeff.BeerDrinkers.Domain.Types;

#nullable disable

namespace Jeff.BeerDrinkers.Domain.Domain
{
    public partial class BeerDrinker
    {
        public int BeerDrinkerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public List<Beer> Beer { get; set; }
    }
}
