using Assets.Scripts;
using UnityEngine;

public class Test_Fridge : MonoBehaviour
{
    [SerializeField] Food food;
    bool colliding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food = new Meat("meat", true, "cow", 0);
    }

    // Update is called once per frame
    void Update()
    {
        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
        if (colliding == true && Input.GetKeyDown(KeyCode.E))
        {
            GameObject player = gameObject.GetComponent<ActionScript>().ReturnCollidingObject();
            player.GetComponent<Holding>().AddFood(food);
        }
    }
}
