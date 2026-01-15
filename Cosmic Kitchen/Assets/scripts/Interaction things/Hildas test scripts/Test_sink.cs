using UnityEngine;

public class Test_sink : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<Holding>().PlaceFood();
    }
}
