using Assets.Scripts;
using Assets.Scripts.Food_related;
using UnityEngine;

public class Test_egg_holder : MonoBehaviour
{
    [SerializeField] Food food;
    bool colliding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food = new Misc("Pegg", false, false, 2);
    }

    // Update is called once per frame
    void Update()
    {
        colliding = gameObject.GetComponent<ActionScript>().ReturnIfPlayerIsColiding();
        if (colliding == true && Input.GetKeyDown(KeyCode.Q))
        {
            GameObject player = gameObject.GetComponent<ActionScript>().ReturnCollidingObject();
            player.GetComponent<Holding>().AddFood(food);
        }
    }
}
