using UnityEngine;

public class Test_sink : MonoBehaviour
{
    float cleaningTime = 2;
    float currentCleaningTime = -1000;
    void Update()
    {
        if (GetComponent<Holding>().ReturnHolding() != null)
        {
            GetComponent<Holding>().PlaceFood();
            GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Movement>().Cleaning();
            currentCleaningTime = cleaningTime;
            Debug.Log("blap");
        }
        if (currentCleaningTime >= 0)
        {
            currentCleaningTime -= Time.deltaTime;
        }
        if (currentCleaningTime <= 0)
        {
            GetComponent<ActionScript>().ReturnCollidingObject().GetComponent<Movement>().StopInteract();
        }
    }
}
