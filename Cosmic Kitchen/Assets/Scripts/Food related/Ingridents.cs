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
    Food meat = new Meat("Steak", true, "cow", 0);


    //List of different veggies
    protected List<Food> veggies = new List<Food>();
    Food potato = new Veggie("Marstato", false, 1);


    //List of different fruits
    protected List<Food> fruits = new List<Food>(); 
    



    //List of different miscallenous food items such as bread or eggs
    protected List<Food> miscs = new List<Food>();
    Food bagette = new Misc("Bluegette", false, true, 2);
    Food egg = new Misc("Pegg", false, false, 3);
    Food flour = new Misc("Flour", false, true, 4);
    


    public Ingridents()
    {
        //Adds differnt meats to list
        meats.Add(meat);


        //Adds different veggies to list
        veggies.Add(potato);



        //Adds different fruits to list
        


        //Adds different miscallenous food items to list
        miscs.Add(bagette);
        miscs.Add(egg);
        miscs.Add(flour);


    }

}
