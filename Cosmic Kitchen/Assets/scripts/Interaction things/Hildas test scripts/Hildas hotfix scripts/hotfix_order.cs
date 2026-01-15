using Assets.Scripts;
using Assets.Scripts.Food_related;
using System;
using System.Collections.Generic;
using UnityEngine;

public class hotfix_order : MonoBehaviour
{
    List<Food> orders = new List<Food>();
    Food fries = new Misc("Fries", true, true, 12);
    Food omelette = new Misc("Omelette", true, false, 13);
    Food panckakes = new ProperFood("Pancakes", true, 11, new Misc("Pegg", false, false, 2), new Misc("Flour", false, true, 3), null, null);
    Food steak = new ProperFood("Steak", true, 10, null, null, new Meat("meat", true, "cow", 0), null);
    int x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orders.Add(fries);
        orders.Add(omelette);
        orders.Add(panckakes);
        orders.Add(steak);
        System.Random rand = new System.Random();
        x = rand.Next(0, orders.Count);
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Food ReturnOrder()
    {
        return orders[x];
    }
    public void RandomizeOrder()
    {
        System.Random rand = new System.Random();
        x = rand.Next(0, orders.Count);
        Debug.Log(x);
    }
}
