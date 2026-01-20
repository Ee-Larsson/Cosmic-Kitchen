using UnityEngine;

public class TestMovement : MonoBehaviour
{

    [SerializeField] float speed;
    Rigidbody2D rb;
    public Animator anim;
    bool isRunning;
    bool isIdle;

    //Adds actions to stop animation;
    public Test_stove1 stove;
    public Test_cuttingboard cuttingboard;


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

    //To get Cooking() or Cleaning(), you have to call it from another class.
    //Use Public TestMovement Player, and put it the player.
    //Then you can just call it by player.Cooking();

    public void Cooking()
    {
        isIdle = false;
        anim.SetTrigger("isCooking");
    }

    public void Cleaning()
    {
        //Has to put in dish, and animate it too for it to work)
        isIdle = false;
        anim.SetTrigger("isCleaning");
    }

    public void Cutting()
    {
        //Has to put in cuttingboard, and animate it too for it to work)
        isIdle = false;
        anim.SetTrigger("isCutting");
    }

    public void StopAnimationCook()
    {
        stove.StopInteract();
        isIdle = true;
    }
    public void StopAnimationCut()
    {
        cuttingboard.StopInteract();
        isIdle = true;
    }




    void ProcessInput()
    {
        

        if ((rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0))
        {
            //Stops running, starts idle animations
            anim.SetBool("isRunning", false);

            // && rb.linearVelocity.x != 0 || rb.linearVelocity.y != 0

        }
        else
        {
            //Starts running animation
            anim.SetBool("isRunning", true);

            //Makes new idle direction with the run worth (Hard to explain <:) )
            lastMoveDirection = rb.linearVelocity;
        }
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
