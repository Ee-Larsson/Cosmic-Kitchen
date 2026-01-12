using Assets.Scripts;
using Assets.Scripts.Food_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Ingridents
{
    //List of different meat
    protected List<Food> meats = new List<Food>();
    Food bleat = new Meat("steak", true, "cow");


    //List of different veggies
    protected List<Food> veggies = new List<Food>();



    //List of different fruits
    protected List<Food> fruits = new List<Food>(); 
    Food blapple = new Fruit("Blapple", false);



    //List of different miscallenous food items such as bread or eggs
    protected List<Food> miscs = new List<Food>();
    Food bluegette = new Misc("Bluegette", false, true);
    Food pegg = new Misc("Egg", false, false);
    Food flour = new Misc("Flour", false, true);
    Food marstato = new Misc("Potato", false, true);


    public Ingridents()
    {
        //Adds differnt meats to list
        meats.Add(bleat);


        //Adds different veggies to list



        //Adds different fruits to list
        fruits.Add(blapple);


        //Adds different miscallenous food items to list
        miscs.Add(bluegette);
        miscs.Add(pegg);
        miscs.Add(flour);
        miscs.Add(marstato);


    }

}
