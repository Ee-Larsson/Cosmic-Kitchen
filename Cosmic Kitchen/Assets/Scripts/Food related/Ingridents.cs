using Assets.Scripts;
using Assets.Scripts.Food_related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;


public class Ingridents : MonoBehaviour
{
    [SerializeField] SpriteRenderer image;

    [SerializeField] List<Sprite> spriteList;


    //List of different meat
    protected List<Food> meats = new List<Food>();
    Food meat = new Meat("meat", true, "cow", 0);


    //List of different veggies
    protected List<Food> veggies = new List<Food>();
    Food potato = new Veggie("Marstato", false, 1);


    //List of different fruits
    protected List<Food> fruits = new List<Food>(); 
    



    //List of different miscallenous food items such as bread or eggs
    protected List<Food> miscs = new List<Food>();
    Food egg = new Misc("Pegg", false, false, 2);
    Food flour = new Misc("Flour", false, true, 3);
    


    public Ingridents()
    {
        //Adds differnt meats to list
        meats.Add(meat);


        //Adds different veggies to list
        veggies.Add(potato);



        //Adds different fruits to list
        


        //Adds different miscallenous ingridients to list
        miscs.Add(egg);
        miscs.Add(flour);


        //Spriteindex nonsense
        image.sprite = spriteList[meat.GetSpriteIndex()];

    }

}
