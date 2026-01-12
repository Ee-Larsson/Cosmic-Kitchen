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
    Food meat = new Meat("Beak", true, "cow");


    //List of different veggies
    protected List<Food> veggies = new List<Food>();



    //List of different fruits
    protected List<Food> fruits = new List<Food>(); 
    Food apple = new Fruit("Blapple", false);



    //List of different miscallenous food items such as bread or eggs
    protected List<Food> miscs = new List<Food>();
    Food bagette = new Misc("Bluegette", false, true);
    Food egg = new Misc("Pegg", false, false);
    Food flour = new Misc("Flour", false, true);
    Food potato= new Misc("Marstato", false, true);


    public Ingridents()
    {
        //Adds differnt meats to list
        meats.Add(meat);


        //Adds different veggies to list



        //Adds different fruits to list
        fruits.Add(apple);


        //Adds different miscallenous food items to list
        miscs.Add(bagette);
        miscs.Add(egg);
        miscs.Add(flour);
        miscs.Add(potato);


    }

}
