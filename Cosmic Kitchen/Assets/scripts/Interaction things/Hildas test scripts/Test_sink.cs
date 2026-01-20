using UnityEngine;

public class Test_sink : MonoBehaviour
{
    public TestMovement player;
    public DiskScript disk;
    void Update()
    {
        
        if (GetComponent<Holding>().ReturnHolding() != null)
        {
            GetComponent<Holding>().PlaceFood();
            disk.DiskCleaning();
        }
    }
}
