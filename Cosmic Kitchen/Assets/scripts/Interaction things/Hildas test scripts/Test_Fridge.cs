using Assets.Scripts;
using Assets.Scripts.Food_related;
using UnityEngine;

public class Test_Fridge : MonoBehaviour
{
    [SerializeField] Food potato = new Veggie("Marstato", false, 1);
    [SerializeField] Food meat = new Meat("meat", true, "cow", 0);
    [SerializeField] Food flour = new Misc("Flour", false, true, 3);
    [SerializeField] Food egg = new Misc("Pegg", false, false, 2);
    bool colliding;
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
            gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder = 3;
        }
        else if (colliding != true)
        {
            gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder = -3;
        }
        if (gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder == 3)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().AddFood(meat);
                gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder = -3;
                Debug.Log("did it");
            }
        }
        if (gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder == 3)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().AddFood(flour);
                gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder = -3;
            }
        }
        if (gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder == 3)
        {
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().AddFood(egg);
                gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder = -3;
            }
        }
        if (gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder == 3)
        {
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                gameObject.GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().AddFood(potato);
                gameObject.transform.Find("fridge inside").GetComponent<SpriteRenderer>().sortingOrder = -3;
            }
        }
    }
}
