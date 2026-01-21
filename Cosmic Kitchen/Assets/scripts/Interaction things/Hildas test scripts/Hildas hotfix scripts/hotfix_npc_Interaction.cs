using UnityEngine;
using UnityEngine.Rendering;

public class hotfix_npc_Interaction : MonoBehaviour
{
    
    bool isActive = false;
    float returnTime;
    float timeItTookForOrder = 0f;
    [SerializeField] float desirableTimeFrame;

    void Start()
    {
        float x = Random.Range(2f, 10f);
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
                float x = Random.Range(2f, 30f);
                returnTime = x;
                GetComponent<hotfix_order>().RandomizeOrder();
            }
        }

    }

    public bool ReturnIfIsActive()
    {
        return isActive;
    }

    public void Activate()
    {
        isActive = true;
        timeItTookForOrder = 0;
    }
    public void DeActivate()
    {
        isActive = false;
    }
}
