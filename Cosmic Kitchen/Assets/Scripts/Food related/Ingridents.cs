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
    List<Meat> meats = new List<Meat>(); 



    //List of different veggies
    List<Veggie> veggies = new List<Veggie>(); 


    //List of different fruits
    List<Fruit> fruits = new List<Fruit>(); 

    Fruit blapple = new Fruit("Blapple", false);

    


    //List of different miscallenous food items such as bread or eggs
    List<Misc> miscs = new List<Misc>();
    Misc bluegette = new Misc("Bluegette", false, false);

    

        public Ingridents()
    {
        //Adds differnt meats to list



        //Adds different veggies to list



        //Adds different fruits to list
        fruits.Add(blapple);


        //Adds different miscallenous food items to list
        miscs.Add(bluegette);

        
    }

}
