using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Food_related
{
    public class Meals : Ingridents
    {
        Random rand = new Random();


        //List of fruits
        List<Food> Fruits = new List<Food>();
        Food blapple = new Fruit("Blapple", true);


        //List of misc food items
        List<Food> general = new List<Food>();
        Food bluegette = new Misc("Bluegette", true, true);
        Food omelette = new Misc("Omelette", true, false);

        //List of proper meals
        List<ProperFood> properMeals = new List<ProperFood>();


        public Meals()
        {
            //Adds fruits to list
            fruits.Add(blapple);

            //Adds misc food items to list
            general.Add(bluegette);
            general.Add(omelette);

            //Adds proper meals to list
            ProperFood MeatAndPotato = new ProperFood(null, null, (Meat)meats[0], (Misc)miscs[3]);
            properMeals.Add(MeatAndPotato);

        }


        public Food GetFruit()
        {

            int x = rand.Next(Fruits.Count);

            return (Fruits[x]);
        }

        public Food GetMisc()
        {

            int x = rand.Next(general.Count);

            return (general[x]);
        }
        public ProperFood GetProperMeals()
        {

            int x = rand.Next(properMeals.Count);

            return (properMeals[x]);
        }
    }
}
