using Assets.Scripts;
using Assets.Scripts.Food_related;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Orders : MonoBehaviour
{
    System.Random rand = new System.Random();

    [SerializeField] GameObject player;

    Food fruitOrder = new Fruit(null, true, 0);
    Food miscOrder = new Misc(null, true, true, 0);
    Food mealOrder = new ProperFood(null, true, 0, null, null, null, null);

    List<string> dialogue = new List<string>();

    Meals meal = new Meals();


    bool toldOrder = false;
    bool fruitGained = false;
    bool mealGained = false;
    bool miscGained = false;

    bool colliding = false;

    int x;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OrderRandomisation();
        x = rand.Next(dialogue.Count);

        dialogue.Add("Hello, i would like " + mealOrder.GetName() + ", along with " + fruitOrder.GetName() + " and " + miscOrder.GetName());
        dialogue.Add("Fluff 1");
        dialogue.Add("Fluff 2");
        dialogue.Add("Fluff 3");
        dialogue.Add("Fluff 4");
        
    }
    
    // Update is called once per frame
    void Update()
    {
        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();

        if(colliding == true && toldOrder == false && Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log(dialogue[x]);

            toldOrder = true;
        }

        if (toldOrder == true && fruitGained == false && mealGained == false && miscGained == false)
        {
            if(fruitOrder == player.GetComponent<Holding>().ReturnHolding() && fruitOrder.GetName() != null)
            {
                fruitGained = true;
            }else 
            if (fruitOrder.GetName() == null)
            {
                fruitGained = true;
            }

            if (mealOrder == player.GetComponent<Holding>().ReturnHolding() && mealOrder.GetName() != null)
            {
                mealGained = true;
            }else 
            if(mealOrder.GetName() == null)
            {
                mealGained = true;
            }

            if (miscOrder == player.GetComponent<Holding>().ReturnHolding() && miscOrder.GetName() != null)
            {
                miscGained = true;
            } else 
            if(miscOrder == null)
            {
                miscGained = true;
            }

            if (miscGained == true && mealGained == true && fruitGained == true)
            {
                Debug.Log("Thank you for the food");
            }


        }


        
    }

    private void OrderRandomisation()
    {

        while(fruitOrder.GetName() == null || mealOrder.GetName() == null || miscOrder.GetName() == null)
        {
            int randomFruit = rand.Next(1, 21);
            Debug.Log(randomFruit);


            int randomMeal = rand.Next(1, 7);
            Debug.Log(randomMeal);


            int randomMisc = rand.Next(1, 9);
            Debug.Log(randomMisc);


            if (randomFruit <= 1)
            {
                fruitOrder = meal.GetFruit();
                Debug.Log(fruitOrder.GetName());
            }

            if (randomMeal > 1)
            {
                mealOrder = meal.GetProperMeals();

                Debug.Log(mealOrder.GetName());
            }

            if (randomMisc <= 2)
            {
                miscOrder = meal.GetMisc();
                Debug.Log(miscOrder.GetName());
            }
        }

    }
}
