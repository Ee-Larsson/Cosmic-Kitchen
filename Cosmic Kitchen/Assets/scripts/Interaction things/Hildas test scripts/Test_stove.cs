using Assets.Scripts;
using UnityEngine;

public class Test_stove : MonoBehaviour
{
    Food holding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        holding = gameObject.GetComponent<Holding>().ReturnHolding();
        if (holding != null)
        {

        }
    }
}
