using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;

    private Vector2 moveInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void OnMove()
    {
        //SmoveInput = 
    }

}
