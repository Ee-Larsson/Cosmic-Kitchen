using Assets.Scripts;
using UnityEngine;

public class what_food : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Food food;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        food = player.GetComponent<Holding>().ReturnHolding();
        if (food == null)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        }
    }
}
