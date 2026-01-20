using UnityEngine;

public class Test_sink : MonoBehaviour
{
    void Update()
    {
        if (GetComponent<Holding>().ReturnHolding() != null)
        {
            GetComponent<Holding>().PlaceFood();
        }
    }
}
