using Assets.Scripts;
using Assets.Scripts.Food_related;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Orders : Meals
{
    System.Random rand = new System.Random();

    [SerializeField] GameObject player;

    Food fruitOrder = new Fruit(null, true, 0);
    Food miscOrder = new Misc(null, true, true, 0);
    Food mealOrder = new ProperFood(null, true, 0, null, null, null, null);

    List<string> dialogue = new List<string>();


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
        x = rand.Next(0, dialogue.Count);

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

        if (toldOrder == true && colliding == true && Input.GetKeyUp(KeyCode.E) && fruitGained == false || mealGained == false || miscGained == false)
        {

            //fruit given to customers
            if (fruitOrder == player.GetComponent<Holding>().ReturnHolding() && fruitOrder.GetName() != null)
            {
                gameObject.GetComponent<Holding>().AddFood(ReturnHolding());
                player.GetComponent<Holding>().PlaceFood();

                fruitGained = true;
            } else
            if (fruitOrder.GetName() == null)
            {
                fruitGained = true;
            }
            else
            if (fruitOrder != player.GetComponent<Holding>().ReturnHolding() && fruitOrder.GetName() != null)
            {
                Debug.Log("Wrong fruit, you fokkin idiot!");
            }


            //Meals given to customers
            if (mealOrder == player.GetComponent<Holding>().ReturnHolding() && mealOrder.GetName() != null)
            {
                gameObject.GetComponent<Holding>().AddFood(ReturnHolding());
                player.GetComponent<Holding>().PlaceFood();
                mealGained = true;
            } else 
            if(mealOrder.GetName() == null)
            {
                mealGained = true;
            } else
            if (mealOrder != player.GetComponent<Holding>().ReturnHolding() && mealOrder.GetName() != null)
            {
                Debug.Log("Wrong meal, you fokkin idiot!");
            }


            //Misc foods given to customers
            if (miscOrder == player.GetComponent<Holding>().ReturnHolding() && miscOrder.GetName() != null)
            {
                gameObject.GetComponent<Holding>().AddFood(ReturnHolding());
                player.GetComponent<Holding>().PlaceFood();
                miscGained = true;
            } else 
            if(miscOrder == null)
            {
                miscGained = true;
            } else
            if(miscOrder != player.GetComponent<Holding>().ReturnHolding() && miscOrder.GetName() != null)
            {
                Debug.Log("Wrong misc food, you fokkin idiot!");
            }

            
            


        }
        //right or wrong food
        if (miscGained == true && mealGained == true && fruitGained == true)
        {
            Debug.Log("Thank you for the food");
            float time = 3.0f;

            time -= Time.deltaTime;
            if(time <= 0)
            {
                Destroy(gameObject);
            }
        }


    }

    private void OrderRandomisation()
    {

        while(fruitOrder.GetName() == null && mealOrder.GetName() == null && miscOrder.GetName() == null)
        {
            int randomFruit = rand.Next(1, 21);
            Debug.Log(randomFruit);


            int randomMeal = rand.Next(1, 7);
            Debug.Log(randomMeal);


            int randomMisc = rand.Next(1, 9);
            Debug.Log(randomMisc);


            if (randomFruit <= 1)
            {
          //      fruitOrder = GetFruit();

          //      Debug.Log(fruitOrder.GetName());
            }

            if (randomMeal > 1)
            {
                mealOrder = GetProperMeals();
                
                Debug.Log(mealOrder.GetName());
            }

            if (randomMisc <= 2)
            {
                miscOrder = GetMisc();

                Debug.Log(miscOrder.GetName());
            }
        }

    }
}
