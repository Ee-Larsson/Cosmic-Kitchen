using UnityEngine;
using System;
using Assets.Scripts.Food_related;

public class Orders : MonoBehaviour
{
    System.Random rand = new System.Random();


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


        int randomMeal = rand.Next(1, 5);


        int randomMisc = rand.Next(1, 9);

        if(randomFruit >= 1)
        {
            Meals.GetFruit();
        }

    }
}
