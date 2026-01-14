using Microsoft.Unity.VisualStudio.Editor;
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
        Food apple = new Fruit("Blapple", true, 0);


        //List of misc food items
        List<Food> general = new List<Food>();
        Food bagette = new Misc("Bluegette", true, true, 11);
        Food fries = new Misc("Fries", true, true, 12);
        Food omelette = new Misc("Omelette", true, false, 13);

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
            ProperFood curryRice = new ProperFood("Curry and rice", 4, null, (Veggie)veggies[0], (Meat)meats[0], null);
            properMeals.Add(curryRice);

            ProperFood dumplings = new ProperFood("Dumplings", 5, null, null, (Meat)meats[0], (Misc)miscs[2]);
            properMeals.Add(dumplings);

            ProperFood eggsAndBacon = new ProperFood("Eggs & Bacon", 6, null, null, (Meat)meats[0], (Misc)miscs[1]);
            properMeals.Add(eggsAndBacon);

            ProperFood gnocci = new ProperFood("Gnocci", 7, null, (Veggie)veggies[0], null,(Misc)miscs[2]);
            properMeals.Add(gnocci);

            ProperFood hashBrown = new ProperFood("Hash brown", 8, null, (Veggie)veggies[0], null, (Misc)miscs[1]);
            properMeals.Add(hashBrown);

            ProperFood pancakes = new ProperFood("Pancakes", 9, (Misc)miscs[1], (Misc)miscs[2], null, null);
            properMeals.Add(pancakes);

            ProperFood steak = new ProperFood("Steak", 10, null, null, (Meat)meats[0], null);
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
