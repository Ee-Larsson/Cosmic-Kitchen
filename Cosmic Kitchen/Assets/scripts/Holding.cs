using Assets.Scripts;
using Assets.Scripts.Food_related;
using System;
using UnityEngine;

public class Holding : MonoBehaviour 
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Food holding = null;
    public Food ReturnHolding()
    {
        return holding;
    }
    public bool AddFood(Food change)
    {
        if (holding == null)
        {
            holding = change;
            
            return true;
        }
        else
        {
            return false;
        }
    }
    public Food PlaceFood()
    {
        if (holding != null)
        {
            Food temp = holding;
            holding = null;
            return holding;
        }
        else
        {
            return null;
        }
    }
}
