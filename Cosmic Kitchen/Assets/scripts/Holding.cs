using Assets.Scripts;
using Assets.Scripts.Food_related;
using UnityEngine;

public class Holding : MonoBehaviour // only for the player
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject holding = null;
    public GameObject ReturnHolding()
    {
        return holding;
    }
    public bool AddFood(GameObject change)
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
    public GameObject PlaceFood()
    {
        if (holding != null)
        {
            GameObject temp = holding;
            holding = null;
            return holding;
        }
        else
        {
            return null;
        }
    }
}
