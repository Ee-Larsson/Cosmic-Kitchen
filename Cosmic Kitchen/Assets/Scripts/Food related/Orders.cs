using UnityEngine;
using System;
using Assets.Scripts.Food_related;
using Assets.Scripts;

public class Orders : MonoBehaviour
{
    System.Random rand = new System.Random();

    Food fruitOrder = new Fruit(null, true, 0);

    Food miscOrder = new Misc(null, true, true, 0);

    ProperFood mealOrder = new ProperFood(null, 0, null, null, null, null);

    Meals meal = new Meals();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OrderRandomisation();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OrderRandomisation()
    {
        int randomFruit = rand.Next(1, 21);


        int randomMeal = rand.Next(1, 7);


        int randomMisc = rand.Next(1, 9);

        if(randomFruit <= 1)
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
