using UnityEngine;

public class hotfix_npc_Interaction : MonoBehaviour
{
    
    bool isActive = false;
    float returnTime;

    void Start()
    {
        System.Random rand = new System.Random();
        float x = rand.Next(2, 20);
        returnTime = x;
    }
    void Update()
    {
        if (GetComponent<ActionScript>().ReturnIfPlayerIsColiding() == true && Input.GetKeyDown(KeyCode.E))
        {
            if (GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().ReturnHolding().GetSpriteIndex() == GetComponent<hotfix_order>().ReturnOrder().GetSpriteIndex())
            {
                if (isActive == true)
                {
                    GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().PlaceFood();
                    isActive = false;
                }
            }
                
        }
        if (isActive == true)
        {
            GetComponent<SpriteRenderer>().sortingOrder = 0;
            GetComponentInChildren<hotfix_show_order>().show();
        }
        else
        {
            GetComponent<SpriteRenderer>().sortingOrder = -1;
            GetComponentInChildren<hotfix_show_order>().hideAway();
            returnTime -= Time.deltaTime;
            if (returnTime <= 0)
            {
                isActive = true;
                System.Random rand = new System.Random();
                float x = rand.Next(2, 20);
                returnTime = x;
                GetComponent<hotfix_order>().RandomizeOrder();
            }
        }

    }

    public bool ReturnIfIsActive()
    {
        return true;
    }

    public void Activate()
    {
        isActive = true;
    }
    public void DeActivate()
    {
        isActive = false;
    }
}
