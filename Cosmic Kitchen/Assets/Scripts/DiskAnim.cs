using UnityEngine;

public class DiskScript : MonoBehaviour
{
    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void DiskCleaning()
    {
        anim.SetTrigger("isCleaning");
    }
}
