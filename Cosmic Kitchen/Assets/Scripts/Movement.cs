using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float speed;
    Rigidbody2D rb;
    public Animator anim;
    bool isRunning;
    bool isIdle;

    //Keeps an idle animation with each direction :)
    Vector2 lastMoveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();

        isIdle = true;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        Animate();

        rb.linearVelocity = new Vector2(0, 0);

        if (isIdle)
        {
            //move up
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.linearVelocity += new Vector2(0, speed);
            }

            //move down
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                rb.linearVelocity += new Vector2(0, -speed);
            }

            //move left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.linearVelocity += new Vector2(-speed, 0);
            }

            //move right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rb.linearVelocity += new Vector2(speed, 0);
            }
        }
    }


    void ProcessInput()
    {

           if ((rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0))
           {
               //Stops running, starts idle animations
               anim.SetBool("isRunning", false);
               
           }
           else
           {
               //Starts running animation
                anim.SetBool("isRunning", true);
               //Makes new idle direction with the run worth (Hard to explain <:) )
               lastMoveDirection = rb.linearVelocity;
           }

    }

    public void Cooking()
    {
        isIdle = false;
        anim.SetTrigger("isCooking");
    }

    public void Cleaning()
    {
        isIdle = false;
        anim.SetTrigger("isCleaning");
    }

    public void StopInteract()
    {
        isIdle = true;
    }


    void Animate()
    {
        //For running
        anim.SetFloat("XInput", rb.linearVelocity.x);
        anim.SetFloat("YInput", rb.linearVelocity.y);

        //For idle
        anim.SetFloat("XLastInput", lastMoveDirection.x);
        anim.SetFloat("YLastInput", lastMoveDirection.y);
    }

}
