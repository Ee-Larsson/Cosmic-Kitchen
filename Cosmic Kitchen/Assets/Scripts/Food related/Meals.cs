using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    public class Meals : Ingridents
    {
        //List of fruits
        List<Food> fruits = new List<Food>();
        Food blapple = new Fruit("Blapple", true);


        //List of misc food items
        List<Food> miscs = new List<Food>();
        Food bluegette = new Misc("Bluegette", false, false);


        //List of proper meals
        List<ProperFood> properMeals = new List<ProperFood>();
        

        public Meals()
        {
            //Adds fruits to list
            fruits.Add(blapple);

            //Adds misc food items to list
            miscs.Add(bluegette);

            //Adds proper meals to list
            ProperFood MeatAndPotato = new ProperFood(null, null, meats[0], null);
            properMeals.Add(MeatAndPotato);

        }
    }
}
