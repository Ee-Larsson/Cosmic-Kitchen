using Assets.Scripts;
using UnityEngine;

public class Test_Fridge : MonoBehaviour
{
    [SerializeField] GameObject player;
    Food food;
    bool colliding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food = new Food("food1", true);
    }

    // Update is called once per frame
    void Update()
    {
        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
        if (colliding == true && Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<Holding>().AddFood(food);
        }
    }
}
