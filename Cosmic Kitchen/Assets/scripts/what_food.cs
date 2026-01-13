using Assets.Scripts;
using System.Collections.Generic;
using UnityEngine;

public class what_food : MonoBehaviour
{
    [SerializeField] Food food;
    [SerializeField] List<Sprite> sprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        food = gameObject.GetComponentInParent<Holding>().ReturnHolding();
        if (food == null)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[food.GetSpriteIndex()];
        }
    }
}
