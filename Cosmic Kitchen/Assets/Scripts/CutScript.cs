using UnityEngine;

public class CutScript : MonoBehaviour
{
    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void BoardCutting()
    {
        anim.SetTrigger("isCutting");
    }
}
