using Assets.Scripts;
using UnityEngine;

public class Test_Bench : MonoBehaviour
{
    bool colliding;
    Food holding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
        if (colliding == true && Input.GetKeyDown(KeyCode.E))
        {
            GameObject player = gameObject.GetComponent<ActionScript>().ReturnCollidingObject();
            if (gameObject.GetComponent<Holding>().ReturnHolding() != null && player.GetComponent<Holding>().ReturnHolding() == null)
            {
                holding = gameObject.GetComponent<Holding>().ReturnHolding();
                player.GetComponent<Holding>().AddFood(holding);
                gameObject.GetComponent<Holding>().PlaceFood();
            }
            else if (gameObject.GetComponent<Holding>().ReturnHolding() == null)
            {
                gameObject.GetComponent<Holding>().AddFood(player.GetComponent<Holding>().PlaceFood());
            }
        }
    }
}
