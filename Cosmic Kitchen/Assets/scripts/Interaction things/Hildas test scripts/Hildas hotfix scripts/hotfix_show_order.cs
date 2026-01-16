using Assets.Scripts;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class hotfix_show_order : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    bool isActive;
    // Update is called once per frame
    void Update()
    {
        //isActive = GetComponentInParent<hotfix_npc_Interaction>().ReturnIfIsActive(); 
        //if (isActive == false)
        //{
        //    GetComponent<SpriteRenderer>().sortingOrder = -10;
        //    Debug.Log("worked for a split second");
        //}
        //else
        //{
        //    GetComponent<SpriteRenderer>().sortingOrder = 10;
        //} didnt fucking work for some reason, I dont fucking understan

        Food food = gameObject.GetComponentInParent<hotfix_order>().ReturnOrder();
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[food.GetSpriteIndex()];

        if (Input.GetKeyDown(KeyCode.C))
        {
            gameObject.GetComponentInParent<hotfix_order>().RandomizeOrder();
        }
    }

    public void hideAway()
    {
        GetComponent<SpriteRenderer>().sortingOrder = -2;
    }
    public void show()
    {
        GetComponent<SpriteRenderer>().sortingOrder = 2;
    }
}
