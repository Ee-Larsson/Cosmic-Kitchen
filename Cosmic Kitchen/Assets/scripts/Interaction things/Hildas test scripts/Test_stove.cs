using Assets.Scripts;
using Assets.Scripts.Food_related;
using UnityEngine;

public class Test_stove : MonoBehaviour
{
    Food holding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        holding = gameObject.GetComponent<Holding>().ReturnHolding();
        if (holding.GetSpriteIndex() == 2) //egg
        {
            gameObject.GetComponent<Holding>().PlaceFood();
            gameObject.GetComponent<Holding>().AddFood(new Misc("Omelette", true, false, 13));
        }
        else if (holding.GetSpriteIndex() == 0) //meat
        {
            gameObject.GetComponent<Holding>().PlaceFood();
            gameObject.GetComponent<Holding>().AddFood(new Misc("Steak", true, false, 10));
        }
        else if (holding.GetSpriteIndex() == 3) //flour
        {
            if (gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding() == true) //if player is coliding, its nested to prevent isues about reading things from null gameobjects
            {
                if (gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().ReturnHolding().GetSpriteIndex() == 2 && Input.GetKeyDown(KeyCode.E)) //if player is holding an egg and is pressing E
                {
                    gameObject.GetComponent<Holding>().PlaceFood();
                    gameObject.GetComponent<Holding>().AddFood(new ProperFood("Pancakes", true, 11, new Misc("Pegg", false, false, 2), new Misc("Flour", false, true, 3), null, null));
                    gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().PlaceFood();
                }
            }
        }
        else if (holding.GetSpriteIndex() == 13) //omelet
        {
            if (gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding() == true) //if player is coliding, its nested to prevent isues about reading things from null gameobjects
            {
                if (gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().ReturnHolding().GetSpriteIndex() == 3 && Input.GetKeyDown(KeyCode.E)) //if player is holding an flour and is pressing E
                {
                    gameObject.GetComponent<Holding>().PlaceFood();
                    gameObject.GetComponent<Holding>().AddFood(new ProperFood("Pancakes", true, 11, new Misc("Pegg", false, false, 2), new Misc("Flour", false, true, 3), null, null));
                    gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().PlaceFood(); //remove the food the player is holding
                }
            }
        }
        else if (holding.GetSpriteIndex() == 4) //cut potato
        {
            gameObject.GetComponent<Holding>().PlaceFood();
            gameObject.GetComponent<Holding>().AddFood(new Misc("Fries", true, true, 12));
        }
    }
}
