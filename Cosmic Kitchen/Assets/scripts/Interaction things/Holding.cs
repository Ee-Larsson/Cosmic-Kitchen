using Assets.Scripts;
using Assets.Scripts.Food_related;
using System;
using UnityEngine;

public class Holding : MonoBehaviour // on players and places that should only hold one food like counters and stuff
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Food holding;
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
            return temp;
        }
        else
        {
            return null;
        }
    }
}
