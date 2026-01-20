using UnityEngine;

public class Test_sink : MonoBehaviour
{
    float cleaningTime = 2;
    float currentCleaningTime = -1;
    void Update()
    {
        if (GetComponent<Holding>().ReturnHolding() != null)
        {
            GetComponent<Holding>().PlaceFood();
        }
    }
}
