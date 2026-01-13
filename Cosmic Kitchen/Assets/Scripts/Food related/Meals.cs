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
        Food apple = new Fruit("Blapple", true);


        //List of misc food items
        List<Food> general = new List<Food>();
        Food bagette = new Misc("Bluegette", true, true);
        Food fries = new Misc("Fries", true, true);
        Food omelette = new Misc("Omelette", true, false);

        //List of proper meals
        List<ProperFood> properMeals = new List<ProperFood>();


        public Meals()
        {
            //Adds fruits to list
            fruits.Add(apple);

            //Adds misc food items to list
            general.Add(bagette);
            general.Add(omelette);
            general.Add(fries);

            //Adds proper meals to list
            ProperFood curryRice = new ProperFood("Curry and rice", null, (Veggie)veggies[0], (Meat)meats[0], null);
            properMeals.Add(curryRice);
            ProperFood dumplings = new ProperFood("Dumplings", null, null, (Meat)meats[0], (Misc)miscs[2]);
            properMeals.Add(dumplings);
            ProperFood eggsAndBacon = new ProperFood("Eggs & Bacon", null, null, (Meat)meats[0], (Misc)miscs[1]);
            properMeals.Add(eggsAndBacon);
            ProperFood gnocci = new ProperFood("Gnocci", null, (Veggie)veggies[0], null,(Misc)miscs[2]);
            properMeals.Add(gnocci);
            ProperFood hashBrown = new ProperFood("Hash brown", null, (Veggie)veggies[0], null, (Misc)miscs[1]);
            properMeals.Add(hashBrown);
            ProperFood pancakes = new ProperFood("Pancakes", (Misc)miscs[1], (Misc)miscs[2], null, null);
            properMeals.Add(pancakes);

            ProperFood steak = new ProperFood("Steak", null, null, (Meat)meats[0], null);
            properMeals.Add(steak);

        }


        public Food GetFruit()
        {

            int x = rand.Next(Fruits.Count);

            return (Fruits[x]);
        }
        public ProperFood GetProperMeals()
        {

            int x = rand.Next(properMeals.Count);

            return (properMeals[x]);
        }

        public Food GetMisc()
        {

            int x = rand.Next(general.Count);

            return (general[x]);
        }
        
    }
}
