using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        //Food apple = new Fruit("Blapple", true, 0);


        //List of misc food items
        List<Food> general = new List<Food>();
        Food bagette = new Misc("Bluegette", true, true, 11);
        Food fries = new Misc("Fries", true, true, 12);
        Food omelette = new Misc("Omelette", true, false, 13);

        //List of proper meals
        List<Food> properMeals = new List<Food>();


        private void Start()
        {
            //Adds fruits to list
            //fruits.Add(apple);

            //Adds misc food items to list
            general.Add(bagette);
            general.Add(omelette);
            general.Add(fries);

            //Adds proper meals to list
            Food curryRice = new ProperFood("Curry and rice", true, 4, null, (Veggie)veggies[0], (Meat)meats[0], null);
            properMeals.Add(curryRice);

            Food dumplings = new ProperFood("Dumplings", true, 5, null, null, (Meat)meats[0], (Misc)miscs[2]);
            properMeals.Add(dumplings);

            Food eggsAndBacon = new ProperFood("Eggs & Bacon", true, 6, null, null, (Meat)meats[0], (Misc)miscs[1]);
            properMeals.Add(eggsAndBacon);

            Food gnocci = new ProperFood("Gnocci", true, 7, null, (Veggie)veggies[0], null,(Misc)miscs[2]);
            properMeals.Add(gnocci);

            Food hashBrown = new ProperFood("Hash brown", true, 8, null, (Veggie)veggies[0], null, (Misc)miscs[1]);
            properMeals.Add(hashBrown);

            Food pancakes = new ProperFood("Pancakes", true, 9, (Misc)miscs[1], (Misc)miscs[2], null, null);
            properMeals.Add(pancakes);

            Food steak = new ProperFood("Steak", true, 10, null, null, (Meat)meats[0], null);
            properMeals.Add(steak);


            //spriteindex nonsense
            image.sprite = spriteList[curryRice.GetSpriteIndex()];

            image.sprite = spriteList[dumplings.GetSpriteIndex()];

            image.sprite = spriteList[eggsAndBacon.GetSpriteIndex()];

            image.sprite = spriteList[gnocci.GetSpriteIndex()];

            image.sprite = spriteList[hashBrown.GetSpriteIndex()];

            image.sprite = spriteList[pancakes.GetSpriteIndex()];

            image.sprite = spriteList[bagette.GetSpriteIndex()];

            image.sprite = spriteList[fries.GetSpriteIndex()];

            image.sprite = spriteList[omelette.GetSpriteIndex()];
        }


        //protected Food GetFruit()
       // {

        //    int x = rand.Next(0, Fruits.Count);

     //       return (Fruits[x]);
      //  }
        protected Food GetProperMeals()
        {

            int x = rand.Next(properMeals.Count);

            print(x);

            return (properMeals[x]);
        }

        protected Food GetMisc()
        {

            int x = rand.Next(0, general.Count);

            return (general[x]);
        }
        
    }
}
