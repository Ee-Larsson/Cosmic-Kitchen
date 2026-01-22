using UnityEngine;
using UnityEngine.Rendering;

public class hotfix_npc_Interaction : MonoBehaviour
{
    
    bool isActive = false;
    float returnTime;
    float timeItTookForOrder = 0f;
    [SerializeField] int score = 0;
    [SerializeField] float desirableTimeFrame;

    void Start()
    {
        float x = Random.Range(2f, 10f);
        returnTime = x;
    }
    void Update()
    {
        if(timeItTookForOrder < 30)
        {
            timeItTookForOrder += Time.deltaTime;
        }

        if(timeItTookForOrder >= 30)
        {
            Debug.Log("YOU'RE TOO FOKKING SLOW!");
            isActive = false;
        }

        if (GetComponent<ActionScript>().ReturnIfPlayerIsColiding() == true && Input.GetKeyDown(KeyCode.E))
        {
            if (GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Holding>().ReturnHolding().GetSpriteIndex() == GetComponent<hotfix_order>().ReturnOrder().GetSpriteIndex())
            {
                if (isActive == true)
                {
                    if (GetComponent<hotfix_order>().ReturnOrder().GetSpriteIndex() == 11) //pancake
                    {
                        if(timeItTookForOrder > 20)
                        {
                            score += 100;
                        }
                        else if(timeItTookForOrder > 10)
                        {
                            score += 75;
                        }
                        else
                        {
                            score += 50;
                        }
                        
                    }
                    else if (GetComponent<hotfix_order>().ReturnOrder().GetSpriteIndex() == 12) // pomefritas
                    {
                        if (timeItTookForOrder > 20)
                        {
                            score += 80;
                        }
                        else if (timeItTookForOrder > 10)
                        {
                            score += 60;
                        }
                        else
                        {
                            score += 40;
                        }
                    }
                    else
                    {
                        if (timeItTookForOrder > 20)
                        {
                            score += 60;
                        }
                        else if (timeItTookForOrder > 10)
                        {
                            score += 45;
                        }
                        else
                        {
                            score += 30;
                        }
                    }
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
                timeItTookForOrder = 0f;
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
    public int ReturnScore()
    {
        return score;
    }

    public void ScoreRemoval()
    {
        score = 0;
    }
}
