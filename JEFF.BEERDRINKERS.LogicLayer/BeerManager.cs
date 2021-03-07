using System;
using System.Collections.Generic;
using System.Linq;
using Jeff.BeerDrinkers.Data;
using Jeff.BeerDrinkers.Domain.Domain;



namespace JEFF.BEERDRINKERS.LogicLayer
{
    public class BeerManager
    {
        BeerDrinkersContext brewContext = new BeerDrinkersContext();



        public IEnumerable<BeerDrinker> GetAllBeerDrinkers()
        {
            BeerDrinkersContext dbContext = new BeerDrinkersContext();
            var beerDrinkers = dbContext.BeerDrinkers.ToList();

            return beerDrinkers;
        }
    }
}
